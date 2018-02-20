using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnuCashCSLib.Business
{
    public class Transaction
    {
        public string Id { get; set; }
 

        public DateTime DatePosted { get; set; }
        public string Description { get; set; }

       

        public override string ToString()
        {
            return String.Format("{0} | {1} | {2} | {3}",   TransactionAccounts.Item1.Name + "," + transactionAccounts.Item2.Name, transactionAccounts.Item1.Amount + "," + transactionAccounts.Item2.Amount, DatePosted.ToString(),Description);
        }

        Tuple<TransactionDetail, TransactionDetail> transactionAccounts;
        public Tuple<TransactionDetail, TransactionDetail> TransactionAccounts
        {
            get
            {
                return transactionAccounts;
            }

            set
            {
                transactionAccounts = value;
            }
        }



    }

    public class TransactionDetail
    {
        public string Name { get; set; }
        public string GUID { get; set; }
        public double Amount { get; set; } 
    }


}
