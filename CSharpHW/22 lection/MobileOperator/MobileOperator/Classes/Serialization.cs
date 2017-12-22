using System.Collections.Generic;
using System.IO;

namespace MobileOperator.Classes
{
    public static class Serialization
    {
        public static void JSONSer(string pathFile, List<MobileAccount> clients)
        {
            var jsonSerializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(pathFile, FileMode.Create))
            {
                jsonSerializer.WriteObject(fs, clients);
            }
            clients.Clear();
        }

        public static List<MobileAccount> JSONDeSer(string pathFile)
        {
            var jsonSerializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream(pathFile, FileMode.Open, FileAccess.Read))
            {
                return (List<MobileAccount>)jsonSerializer.ReadObject(fs);
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
