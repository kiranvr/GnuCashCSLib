using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GnuCashCSLib.XMLSerializerClasses;

namespace GnuCashCSLib.Business
{
    class GNUCashAccMgr
    {
        List<XMLBookAccount> accListExceptRoot = null;
        public void BasicParentPrint()
        {

            var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;


            foreach (var acc in gnuCashRecordRoot.Book.Account)
            {
                Console.WriteLine(acc.name);
                var parentAcc = gnuCashRecordRoot.Book.Account.Where(x => x.id.Value.Equals(acc.parent.Value)).FirstOrDefault();
                var parentAccName = "";
                if (parentAcc != null)
                {
                    parentAccName = parentAcc.name;
                }
                Console.WriteLine("parent=" + parentAccName);
            }

        }


      

        /// <summary>
        /// Get the full Acc Hierarchy from the root.
        /// </summary>
        /// <returns></returns>
        public Account GetAccountHierarchy()
        {
            var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;

            var rootAcc = gnuCashRecordRoot.Book.Account.Where(x => x.parent.Value == "-1").FirstOrDefault();
            if (this.accListExceptRoot==null)
            {                
                accListExceptRoot = gnuCashRecordRoot.Book.Account.Where(x => x.parent.Value!="-1").ToList();
            }
            AddChildren(GetEquivalentAccout(rootAcc), true);
            return this.rootAccWithHierarchy;
        }
        /// <summary>
        /// Get acc hierarchy starting from any give nod in th eorginal chain
        /// </summary>
        /// <param name="accGUID"></param>
        /// <returns></returns>
        public Account GetAccountHierarchy(string accGUID)
        {
            var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;
            var rootAcc = gnuCashRecordRoot.Book.Account.Where(x => x.id.Value==accGUID).FirstOrDefault();
            accListExceptRoot = gnuCashRecordRoot.Book.Account.Where(x => x.parent != null).ToList();
            AddChildren(GetEquivalentAccout(rootAcc), true);
            return this.rootAccWithHierarchy;
        }


        static List<Account> flattendAccount= new List<Account>();

        public static List<Account> FlattenAccountHierarchy(Account account)
        {  
            flattendAccount.Add(account);
            foreach (var acc in account.Children)
            {
                FlattenAccountHierarchy(acc);
            }

            return flattendAccount;
        }

        Account rootAccWithHierarchy = null;
        void AddChildren(Account account, bool isRootAccount)
        {

            if (isRootAccount)
            {
                this.rootAccWithHierarchy = account;
            }

            var children = accListExceptRoot.Where(x => x.parent.Value == account.GUID).ToList();
            account.Children = GetEquivalentAccouts(children);

            foreach (var childAcc in account.Children)
            {
                AddChildren(childAcc, false);
            }


        }

        List<Account> GetEquivalentAccouts(List<XMLBookAccount> bookAccounts)
        {
            List<Account> accounts = new List<Account>();

            foreach (var bookAcc in bookAccounts)
            {
                var account = GetEquivalentAccout(bookAcc);
                accounts.Add(account);
            }

            return accounts;
        }

        Account GetEquivalentAccout(XMLBookAccount bookAccount)
        {
            Account account = new Account();
            account.Name = bookAccount.name;
            account.GUID = bookAccount.id.Value;
            account.AnsestorList = bookAccount.AnsestorList;
            return account;
        }
       
        

        public static string GetAccNameByGUID(string accGUID)
        {
            var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;
            return gnuCashRecordRoot.Book.Account.Where(x => x.id.Value == accGUID).FirstOrDefault().name;
        }


    }


}
