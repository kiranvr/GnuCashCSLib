using GnuCashCSLib.XMLSerializerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnuCashCSLib.Business
{
    class GNUCashTransactionMgr
    {
        GNUCashAccMgr gnuCashAccMgr = new GNUCashAccMgr();
        Transaction GetEquivalentTransaction(XMLBookTransaction xmlTransaction, string accGUID)
        {
            //XMLSplitsSplit chosenSplit = null;
            //if (xmlTransaction.splits[0].Mark == null)//TODO if a tag is used at xmlTranslevel-polymorphism can help elegantly
            //{
            //    chosenSplit = GetDesiredSplit(xmlTransaction, accGUID);
            //}
            //else
            //{
            //    chosenSplit = GetDesiredSplit(xmlTransaction);
            //}


            Transaction transaction = new Transaction();

            TransactionDetail d1 = new TransactionDetail();
            d1.Amount = xmlTransaction.splits[0].quantity.EvaluateExpression();
            d1.Name = GNUCashAccMgr.GetAccNameByGUID( xmlTransaction.splits[0].account.Value);

            TransactionDetail d2 = new TransactionDetail();
            d2.Amount = xmlTransaction.splits[1].quantity.EvaluateExpression();
            d2.Name = GNUCashAccMgr.GetAccNameByGUID(xmlTransaction.splits[1].account.Value);


            transaction.TransactionAccounts = Tuple.Create(d1, d2);

            //transaction.AccountName = gnuCashAccMgr.GetAccNameByGUID(chosenSplit.account.Value);
            //transaction.Amount = chosenSplit.quantity.EvaluateExpression();
            transaction.DatePosted = DateTime.Parse(xmlTransaction.dateposted.date);//TODO Check culture and apply
            transaction.Id = xmlTransaction.id.Value;
            transaction.Description = xmlTransaction.description;

            return transaction;


        }

        private XMLSplitsSplit GetDesiredSplit(XMLBookTransaction xmlTransaction, string rootAcccGUID)
        {
            var parentAcc = gnuCashAccMgr.GetAccountHierarchy(rootAcccGUID);//TODO provider class to implement caching 
            var accountList = GNUCashAccMgr.FlattenAccountHierarchy(parentAcc);//TODO provider class to implement caching 
            var chosenSplit = xmlTransaction.splits.Where(x => accountList.Any(xx => xx.GUID.Contains(x.account.Value))).FirstOrDefault();
            return chosenSplit;
        }
        /// <summary>
        /// works if split is tagged earler.
        /// </summary>
        /// <param name="xmlTransaction"></param>
        /// <returns></returns>
        private XMLSplitsSplit GetDesiredSplit(XMLBookTransaction xmlTransaction)
        {
            return xmlTransaction.splits.Where(x => x.Mark.Contains("CHOSEN")).FirstOrDefault();
        }
        public List<Transaction> GetTransactions(string accGUID, bool isRecusrsive)
        {
            var v = this.GetXMLTramsactions(accGUID, isRecusrsive);

            List<Transaction> transactions = new List<Transaction>();

            foreach (var xmlTransaction in v)
            {
                var transaction = GetEquivalentTransaction(xmlTransaction, accGUID);
                transactions.Add(transaction);
            }

            return transactions;
        }



        public List<XMLBookTransaction> GetXMLTramsactions(string accGUID, bool isRecursive)
        {
            List<XMLBookTransaction> transactions = null;
            if (isRecursive)
            {
                var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;
                transactions = gnuCashRecordRoot.Book.Transaction.Where(transaction => transaction.splits.ISTHISCANDIDATEX(accGUID)).ToList();
            }
            else
            {
                //TODO --Test this non recursive version-its untested yet. 
                var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;
                transactions = gnuCashRecordRoot.Book.Transaction.Where(transaction => transaction.splits.Any(split => split.account.Value == accGUID)).ToList();
            }



            return transactions;
        }



    }
}
