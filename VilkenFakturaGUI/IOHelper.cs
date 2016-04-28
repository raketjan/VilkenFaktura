using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VilkenFakturaGUI.Entities;

namespace VilkenFakturaGUI
{
    public static class IOHelper
    {
        public static void SaveFile(ObservableCollection<Invoice> Invoices, Decimal sum, string filepath)
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Invoice>));
                writer = new StreamWriter(filepath, false);
                serializer.Serialize(writer, Invoices);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                
            }
        }

        public static ObservableCollection<Invoice> LoadFile(string filepath)
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Invoice>));
                reader = new StreamReader(filepath);
                return (ObservableCollection<Invoice>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static ObservableCollection<Invoice> ImportFile(string filepath)
        {
             try
            {
                ObservableCollection<Invoice> invoices = new ObservableCollection<Invoice>();
                StreamReader reader = new StreamReader(filepath);
                string line;
                Decimal cost;
                int id = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Decimal.TryParse(line, out cost))
                    {
                        invoices.Add(new Invoice()
                        {
                            Id = id++,
                            Name = "",
                            Cost = cost,
                            Include = true
                        });
                    }
                }
                return invoices; 
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {               
            }
        }
    }
}
