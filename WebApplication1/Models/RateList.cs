using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1.Models
{
    [XmlRoot("ValCurs")]
    [Serializable]
    public class RateList
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("Date")]
        public string Date { get; set; }

        [XmlElement("Valute")]
        public List<Rate> Valutes { get; set; }
    }
}
