using GnuCashCSLib.XMLSerializerClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnuCashCSLib.Business
{



    public static class exxx
    {
        public static bool ISTHISCANDIDATEX(this IEnumerable<XMLSplitsSplit> XMLSplits, string accountGUID)
        {
            bool found = false;

            var gnuCashRecordRoot = GNUCashMgr.GetInstance().GnuCashRecordRoot;
            
            foreach (var xmlSplit in XMLSplits)
            {
                var acc = GNUCashMgr.GetInstance().GetXMLAccount(xmlSplit.account.Value);
                found = acc.IsAncestor(accountGUID);
                if (found)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }

            //GNUCashAccMgr accMgr = new GNUCashAccMgr();
            ////var hierarchyForChosenParent = accMgr.GetAccountHierarchy(accountGUID);
            ////var accList = GNUCashAccMgr.FlattenAccountHierarchy(hierarchyForChosenParent);
            //accMgr.i

            //foreach (var acc in accList)
            //{
            //   if( XMLSplits.Any(x => x.account.Value == acc.GUID))
            //    {
            //        var qualifiedSplite= XMLSplits.Where(x => x.account.Value == acc.GUID).FirstOrDefault();
            //        qualifiedSplite.Mark = "YES THIS IS THE ONE CHOSEN";

            //        var couterpartSplit = XMLSplits.Where(x => x.account.Value != acc.GUID).FirstOrDefault();
            //        couterpartSplit.Mark = "THE COUNTERPART";//This will help avoid cleaning for the next run where both could be marked as chosen.

            //        found = true;
            //        break;

            //    }
            //}

            return found;
        }
        public static double EvaluateExpression(this string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
