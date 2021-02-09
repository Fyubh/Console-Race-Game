using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed2._0
{
    static class Record
    {
        static private List<KeyValuePair<string, uint>> Scores = new List<KeyValuePair<string, uint>>();

        static public void Write(string filename)
        {
            Console.Clear();
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Scores.Add(new KeyValuePair<string, uint>(name, Globals.Score));
            XmlWriterSettings settings = new XmlWriterSettings();
            //settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(filename, settings))
            {
                writer.WriteStartElement("root");
                foreach (KeyValuePair<string, uint> pair in Scores)
                {
                    writer.WriteStartElement("Record");
                    writer.WriteAttributeString("Name", pair.Key);
                    writer.WriteElementString("Score", pair.Value.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Close();
            }
        }
        static public void Read(string filename)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            using (XmlReader reader = XmlReader.Create(filename, settings))
            {
                string Name = null;
                uint score = 0;

                while (reader.Read())
                {
                    //Console.WriteLine($"Тип: \'{reader.NodeType}\' Имя: \'{reader.Name}\' Значение: \'{reader.Value}\'");
                    if (reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("Record") == 0)
                    {
                        Name = reader.GetAttribute("Name");
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name.CompareTo("Score") == 0)
                    {
                        reader.Read();
                        score = Convert.ToUInt32(reader.Value);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name.CompareTo("Record") == 0)
                    {
                        Scores.Add(new KeyValuePair<string, uint>(Name, score));
                    }
                }
                reader.Close();
            }
        }
        static public void Show()
        {
            Console.Clear();
            Console.WriteLine("[РЕКОРДЫ]\n\nИмя\t\t\tРекорд");
            foreach (KeyValuePair<string, uint> pair in Scores)
            {
                Console.WriteLine($"{pair.Key}\t\t\t{pair.Value}");
            }
        }
    }
}
