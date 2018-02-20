//using System;
//using System.Xml.Serialization;
//using System.Collections.Generic;

//namespace GNUCashCSharp
//{
 
  
 
//        [XmlRoot(ElementName = "count-data", Namespace = "http://www.gnucash.org/XML/gnc")]
//        public class Countdata
//        {
//            [XmlAttribute(AttributeName = "type", Namespace = "http://www.gnucash.org/XML/cd")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "id", Namespace = "http://www.gnucash.org/XML/book")]
//        public class Id
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "commodity", Namespace = "http://www.gnucash.org/XML/gnc")]
//        public class Commodity
//        {
//            [XmlElement(ElementName = "space", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Space { get; set; }
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Id2 { get; set; }
//            [XmlAttribute(AttributeName = "version")]
//            public string Version { get; set; }
//        }

//        [XmlRoot(ElementName = "id", Namespace = "http://www.gnucash.org/XML/act")]
//        public class Id2
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "commodity", Namespace = "http://www.gnucash.org/XML/act")]
//        public class Commodity2
//        {
//            [XmlElement(ElementName = "space", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Space { get; set; }
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Id3 { get; set; }
//        }

//        [XmlRoot(ElementName = "value", Namespace = "http://www.gnucash.org/XML/slot")]
//        public class Value
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "slot")]
//        public class Slot
//        {
//            [XmlElement(ElementName = "key", Namespace = "http://www.gnucash.org/XML/slot")]
//            public string Key { get; set; }
//            [XmlElement(ElementName = "value", Namespace = "http://www.gnucash.org/XML/slot")]
//            public Value Value { get; set; }
//        }

//        [XmlRoot(ElementName = "slots", Namespace = "http://www.gnucash.org/XML/act")]
//        public class Slots
//        {
//            [XmlElement(ElementName = "slot")]
//            public List<Slot> Slot { get; set; }
//        }

//        [XmlRoot(ElementName = "account", Namespace = "http://www.gnucash.org/XML/gnc")]
//        public class Account
//        {
//            [XmlElement(ElementName = "name", Namespace = "http://www.gnucash.org/XML/act")]
//            public string Name { get; set; }
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/act")]
//            public Id2 Id2 { get; set; }
//            [XmlElement(ElementName = "type", Namespace = "http://www.gnucash.org/XML/act")]
//            public string Type { get; set; }
//            [XmlElement(ElementName = "commodity", Namespace = "http://www.gnucash.org/XML/act")]
//            public Commodity2 Commodity2 { get; set; }
//            [XmlElement(ElementName = "commodity-scu", Namespace = "http://www.gnucash.org/XML/act")]
//            public string Commodityscu { get; set; }
//            [XmlElement(ElementName = "slots", Namespace = "http://www.gnucash.org/XML/act")]
//            public Slots Slots { get; set; }
//            [XmlAttribute(AttributeName = "version")]
//            public string Version { get; set; }
//            [XmlElement(ElementName = "description", Namespace = "http://www.gnucash.org/XML/act")]
//            public string Description { get; set; }
//            [XmlElement(ElementName = "parent", Namespace = "http://www.gnucash.org/XML/act")]
//            public Parent Parent { get; set; }
//        }

//        [XmlRoot(ElementName = "parent", Namespace = "http://www.gnucash.org/XML/act")]
//        public class Parent
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "id", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Id3
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "currency", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Currency
//        {
//            [XmlElement(ElementName = "space", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Space { get; set; }
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Id4 { get; set; }
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/cmdty")]
//            public string Id5 { get; set; }
//        }

//        [XmlRoot(ElementName = "date-posted", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Dateposted
//        {
//            [XmlElement(ElementName = "date", Namespace = "http://www.gnucash.org/XML/ts")]
//            public string Date { get; set; }
//        }

//        [XmlRoot(ElementName = "date-entered", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Dateentered
//        {
//            [XmlElement(ElementName = "date", Namespace = "http://www.gnucash.org/XML/ts")]
//            public string Date { get; set; }
//        }

//        [XmlRoot(ElementName = "id", Namespace = "http://www.gnucash.org/XML/split")]
//        public class Id4
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "account", Namespace = "http://www.gnucash.org/XML/split")]
//        public class Account2
//        {
//            [XmlAttribute(AttributeName = "type")]
//            public string Type { get; set; }
//            [XmlText]
//            public string Text { get; set; }
//        }

//        [XmlRoot(ElementName = "split", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Split
//        {
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/split")]
//            public Id4 Id4 { get; set; }
//            [XmlElement(ElementName = "reconciled-state", Namespace = "http://www.gnucash.org/XML/split")]
//            public string Reconciledstate { get; set; }
//            [XmlElement(ElementName = "value", Namespace = "http://www.gnucash.org/XML/split")]
//            public string Value2 { get; set; }
//            [XmlElement(ElementName = "quantity", Namespace = "http://www.gnucash.org/XML/split")]
//            public string Quantity { get; set; }
//            [XmlElement(ElementName = "account", Namespace = "http://www.gnucash.org/XML/split")]
//            public Account2 Account2 { get; set; }
//        }

//        [XmlRoot(ElementName = "splits", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Splits
//        {
//            [XmlElement(ElementName = "split", Namespace = "http://www.gnucash.org/XML/trn")]
//            public List<Split> Split { get; set; }
//        }

//        [XmlRoot(ElementName = "transaction", Namespace = "http://www.gnucash.org/XML/gnc")]
//        public class Transaction
//        {
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Id3 Id3 { get; set; }
//            [XmlElement(ElementName = "currency", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Currency Currency { get; set; }
//            [XmlElement(ElementName = "date-posted", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Dateposted Dateposted { get; set; }
//            [XmlElement(ElementName = "date-entered", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Dateentered Dateentered { get; set; }
//            [XmlElement(ElementName = "description", Namespace = "http://www.gnucash.org/XML/trn")]
//            public string Description { get; set; }
//            [XmlElement(ElementName = "splits", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Splits Splits { get; set; }
//            [XmlAttribute(AttributeName = "version")]
//            public string Version { get; set; }
//            [XmlElement(ElementName = "slots", Namespace = "http://www.gnucash.org/XML/trn")]
//            public Slots2 Slots2 { get; set; }
//        }

//        [XmlRoot(ElementName = "slots", Namespace = "http://www.gnucash.org/XML/trn")]
//        public class Slots2
//        {
//            [XmlElement(ElementName = "slot")]
//            public Slot Slot { get; set; }
//        }

//        [XmlRoot(ElementName = "book", Namespace = "http://www.gnucash.org/XML/gnc")]
//        public class Book
//        {
//            [XmlElement(ElementName = "id", Namespace = "http://www.gnucash.org/XML/book")]
//            public Id Id { get; set; }
//            [XmlElement(ElementName = "count-data", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public List<Countdata> Countdata { get; set; }
//            [XmlElement(ElementName = "commodity", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public Commodity Commodity { get; set; }
//            [XmlElement(ElementName = "account", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public List<Account> Account { get; set; }
//            [XmlElement(ElementName = "transaction", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public List<Transaction> Transaction { get; set; }
//            [XmlAttribute(AttributeName = "version")]
//            public string Version { get; set; }
//        }

//        [XmlRoot(ElementName = "gnc-v2")]
//        public class Gncv2
//        {
//            [XmlElement(ElementName = "count-data", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public Countdata Countdata { get; set; }
//            [XmlElement(ElementName = "book", Namespace = "http://www.gnucash.org/XML/gnc")]
//            public Book Book { get; set; }
//            [XmlAttribute(AttributeName = "book", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string _Book { get; set; }
//            [XmlAttribute(AttributeName = "gnc", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Gnc { get; set; }
//            [XmlAttribute(AttributeName = "act", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Act { get; set; }
//            [XmlAttribute(AttributeName = "cd", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Cd { get; set; }
//            [XmlAttribute(AttributeName = "cmdty", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Cmdty { get; set; }
//            [XmlAttribute(AttributeName = "price", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Price { get; set; }
//            [XmlAttribute(AttributeName = "slot", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Slot { get; set; }
//            [XmlAttribute(AttributeName = "split", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Split { get; set; }
//            [XmlAttribute(AttributeName = "trn", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Trn { get; set; }
//            [XmlAttribute(AttributeName = "ts", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Ts { get; set; }
//            [XmlAttribute(AttributeName = "sx", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Sx { get; set; }
//            [XmlAttribute(AttributeName = "bgt", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Bgt { get; set; }
//            [XmlAttribute(AttributeName = "recurrence", Namespace = "http://www.w3.org/2000/xmlns/")]
//            public string Recurrence { get; set; }
//        }

 

//}
