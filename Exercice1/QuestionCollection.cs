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

    public class QuestionCollection
    {
        public static void Save(string filename, List<Question> questions)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Question>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                ser.Serialize(fs, questions);
            }
        }
        public static List<Question> CreateFromFile(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Question>));
            List<Question> questions = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                questions = (List<Question>)ser.Deserialize(fs);
            }
            return questions;
        }
    }
}
