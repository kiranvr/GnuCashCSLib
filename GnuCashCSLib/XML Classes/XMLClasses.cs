using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnuCashCSLib.XMLSerializerClasses
{



    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("gnc-v2", Namespace = "", IsNullable = false)]
    public class XMLGNCV2
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("count-data", Namespace = "http://www.gnucash.org/XML/gnc")]
        public XMLCountData CountData { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("book", Namespace = "http://www.gnucash.org/XML/gnc")]
        public XMLBook Book { get; set; }

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    [System.Xml.Serialization.XmlRootAttribute("count-data", Namespace = "http://www.gnucash.org/XML/gnc", IsNullable = false)]
    public partial class XMLCountData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.gnucash.org/XML/cd")]
        public string Type { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value { get; set; }

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/gnc", IsNullable = false)]
    public partial class XMLBook
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id", Namespace = "http://www.gnucash.org/XML/book")]
        public XMLId Id { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("count-data")]
        public XMLBookCountData[] CountData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("commodity")]
        public XMLBookCommodity Commodity { get; set; }

        /// <remarks/>

        [System.Xml.Serialization.XmlElementAttribute("account")]
        public XMLBookAccount[] Account { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("transaction")]
        public XMLBookTransaction[] Transaction { get; set; }

        /// <remarks/>

        [System.Xml.Serialization.XmlAttributeAttribute("version")]
        public string Version { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/book")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/book", IsNullable = false)]
    public partial class XMLId
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    public partial class XMLBookCountData
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.gnucash.org/XML/cd")]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    public partial class XMLBookCommodity
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string space { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    public partial class XMLBookAccount
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public string name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public XMLId1 id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public XMLCommodity commodity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("commodity-scu", Namespace = "http://www.gnucash.org/XML/act")]
        public byte commodityscu { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public string description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        [System.Xml.Serialization.XmlArrayItemAttribute("slot", Namespace = "", IsNullable = false)]
        public XMLSlot[] slots { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/act")]
        public XMLParent parent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }

        List<Tuple<string, string>> ansestorList;

        [System.Xml.Serialization.XmlIgnore]
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

        public bool IsPredessessor(string accGUID)
        {
            return this.ansestorList.Any(x => x.Item1 == accGUID);
        }

        public override string ToString()
        {
            return this.name;
        }


    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/act")]
    [System.Xml.Serialization.XmlRootAttribute("id", Namespace = "http://www.gnucash.org/XML/act", IsNullable = false)]
    public partial class XMLId1
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/act")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/act", IsNullable = false)]
    public partial class XMLCommodity
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string space { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string id { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class XMLSlot
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/slot")]
        public string key { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/slot")]
        public XMLValueClass value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/slot")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/slot", IsNullable = false)]
    public partial class XMLValueClass
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/act")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/act", IsNullable = false)]
    public partial class XMLParent
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/gnc")]
    public partial class XMLBookTransaction
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/trn")]
        public XMLId2 id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/trn")]
        public XMLCurrency currency { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date-posted", Namespace = "http://www.gnucash.org/XML/trn")]
        public XMLDatePosted dateposted { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("date-entered", Namespace = "http://www.gnucash.org/XML/trn")]
        public XMLDateEntered dateentered { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/trn")]
        public string description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/trn")]
        public XMLSlots1 slots { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.gnucash.org/XML/trn")]
        [System.Xml.Serialization.XmlArrayItemAttribute("split", IsNullable = false)]
        public XMLSplitsSplit[] splits { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute("id", Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLId2
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLCurrency
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string space { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/cmdty")]
        public string id { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute("date-posted", Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLDatePosted
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/ts")]
        public string date { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute("date-entered", Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLDateEntered
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/ts")]
        public string date { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute("slots", Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLSlots1
    {

        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public XMLSlot slot { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    public partial class XMLSplitsSplit
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/split")]
        public XMLId3 id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("reconciled-state", Namespace = "http://www.gnucash.org/XML/split")]
        public string reconciledstate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/split")]
        public string value { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/split")]
        public string quantity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnucash.org/XML/split")]
        public XMLAccount account { get; set; }
        public string Mark { get;  set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/split")]
    [System.Xml.Serialization.XmlRootAttribute("id", Namespace = "http://www.gnucash.org/XML/split", IsNullable = false)]
    public partial class XMLId3
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/split")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/split", IsNullable = false)]
    public partial class XMLAccount
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }


    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/act")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/act", IsNullable = false)]
    public partial class XMLSlots
    {



        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("slot", Namespace = "")]
        public XMLSlot[] slot { get; set; }
    }
     
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnucash.org/XML/trn")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnucash.org/XML/trn", IsNullable = false)]
    public partial class XMLSplits
    {


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("split")]
        public XMLSplitsSplit[] split { get; set; }
    }


}
