using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Protob

namespace MobileOperator.Classes
{
    public static class Serialization
    {

        public static void BinSer( List<MobileAccount> clients ) 
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.txt", FileMode.Create))
            {
                binaryFormatter.Serialize(fs, clients);
            }
            clients.Clear();

            using (FileStream fs = new FileStream("people.txt",  FileMode.Open, FileAccess.Read))
            {
                clients = (List<MobileAccount>) binaryFormatter.Deserialize(fs);
            }
            /*Console.WriteLine("Binary deserialization");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.MobileNumber}");
            }*/

            //Console.ReadKey();
        }

        public static void XMLSer( List<MobileAccount> clients )
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream("people.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, clients);
            }
            clients.Clear();

            using (FileStream fs = new FileStream("people.xml", FileMode.Open, FileAccess.Read))
            {
                clients = (List<MobileAccount>)xmlSerializer.Deserialize(fs);
            }
            /*Console.WriteLine("XML deserialization");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.MobileNumber}");
            }*/

            //Console.ReadKey();
        }

        public static void JSONSer(List<MobileAccount> clients)
        {
            var jsonSerializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream("people.json", FileMode.Create))
            {
                jsonSerializer.WriteObject(fs, clients);
            }
            clients.Clear();

            using (FileStream fs = new FileStream("people.json", FileMode.Open, FileAccess.Read))
            {
                clients = (List<MobileAccount>)jsonSerializer.ReadObject(fs);
            }
            /*Console.WriteLine("JSon deserialization");
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.MobileNumber}");
            }*/

            //Console.ReadKey();
        }
    }
}
