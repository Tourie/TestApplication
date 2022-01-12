using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1.Models
{
    [XmlType("Valute")]
    [Serializable]
    public class Rate
    {
        [XmlAttribute("ID")]
        public string Id { get; set; }
        [XmlElement("NumCode")]
        public string NumCode { get; set; }
        [XmlElement("CharCode")]
        public string CharCode { get; set; }
        [XmlElement("Nominal")]
        public string Nominal { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Value")]
        public string Value { get; set; }
    }
}
