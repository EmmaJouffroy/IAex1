using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Exercice1
{
    [Serializable()]
    public class Question
    {
        [System.Xml.Serialization.XmlElementAttribute("IDQuestion")]
        public int IDQuestion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Intitule")]
        public string Intitule { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Reponses")]

        public string[] ImagePath { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ImagePath")]
        public string[] Reponses { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ID_BonneReponse")]
        public int ID_BonneReponse { get; set; }

        public Question()
        {
        }


    }
}