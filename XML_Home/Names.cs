using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Home
{
    [Serializable]
    public class Names
    {
        public List<Name> NamesList { get; set; } = new List<Name>();
    }

    [Serializable]
    public class Name
    {
        [XmlElement("Best XML file")]
        public string Instname { get; set; }
        public int Type { get; set; }
        public int Year_of_origin { get; set; } 

        public Name() { }

        public Name(string Instname, int Type, int Year_of_origin)
        {
            this.Instname = Instname;
            this.Type = Type;
            this.Year_of_origin = Year_of_origin;
        }
    }
}
