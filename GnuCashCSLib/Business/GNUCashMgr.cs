using GnuCashCSLib.XMLSerializerClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GnuCashCSLib.Business
{
    class GNUCashMgr//TODO improve singleton
    {
        static GNUCashMgr instance = null;
        XMLGNCV2 gnuCashRecordRoot = null;
        private GNUCashMgr()
        {
            using (FileStream fileStream = new FileStream(@"G:\KIRAN\Projects\GNUCashCSharp\GNUCashCSharp\GNUCashCSharp\sample.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XMLGNCV2));
                gnuCashRecordRoot = (XMLGNCV2)serializer.Deserialize(fileStream);
            }

            AddAncestorList();

        }

        public static GNUCashMgr GetInstance()
        {

            if (instance == null)
            {
                instance = new GNUCashMgr();
            }


            return instance;
        }

        void AddAncestorList()
        {

            var rootAcc = GnuCashRecordRoot.Book.Account.Where(x => x.parent == null).FirstOrDefault();
            //ancestorList = new List<Tuple<string, string>>();
            //ancestorList.Add(Tuple.Create(rootAcc.id.Value, rootAcc.name));
            //rootAcc.AnsestorList = this.ancestorList;
            rootAcc.parent = new XMLParent() { type = "Event Horizon", Value = "-1" }; //To avoid null ref exception in LINQ
            VisitChildren(rootAcc, true);
        }


        void VisitChildren(XMLBookAccount account, bool isRoot)
        {
            ancestorList = new List<Tuple<string, string>>();


            AddParentInfo(account);

            account.AnsestorList = this.ancestorList;

            var children = GnuCashRecordRoot.Book.Account.Where(x => x.parent.Value == account.id.Value).ToList();

            foreach (var child in children)
            {
                VisitChildren(child, false);
            }

        }

        List<Tuple<string, string>> ancestorList;

        public XMLGNCV2 GnuCashRecordRoot
        {
            get
            {
                return gnuCashRecordRoot;
            }


        }
        public XMLBookAccount GetXMLAccount(string accGUID)
        {
            return this.gnuCashRecordRoot.Book.Account.Where(x => x.id.Value.Equals(accGUID)).FirstOrDefault();

        }
        void AddParentInfo(XMLBookAccount account)
        {

            var parent = GnuCashRecordRoot.Book.Account.Where(x => x.id.Value == account.parent.Value).FirstOrDefault();
            Tuple<string, string> ancestor = Tuple.Create(account.id.Value, account.name);
            ancestorList.Add(ancestor);
            if (parent != null)
            {
                AddParentInfo(parent);
            }
        }


    }
}
