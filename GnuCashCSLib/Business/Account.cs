using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnuCashCSLib.Business
{
    public class Account
    {//TODO consider making props as readonly and allow changes only through ctr.
        public string Name { get; set; }
        public string GUID { get; set; }
        public List<Account> Children { get; set; }

        List<Tuple<string, string>> ansestorList;
        public List<Tuple<string, string>> AnsestorList
        {
            get
            {
                return ansestorList;
            }

            set
            {
                ansestorList = value;
            }
        }
        public bool IsAncestor(string accGUID)
        {
            return this.ansestorList.Any(x => x.Item1 == accGUID);
        }
        public override string ToString()
        {
            return this.Name;
        }

        public bool IsSelected { get; set; }

    }
}
