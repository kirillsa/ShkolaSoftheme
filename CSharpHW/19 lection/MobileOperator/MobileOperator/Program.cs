using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobOperator = new Operator();
            List<MobileAccount> clients = new List<MobileAccount>();
            var numOfClients = 5;
            for (var i = 0; i < numOfClients; i++)
            {
                clients.Add(new MobileAccount (i, mobOperator));
            }

            mobOperator.Messaging += Show_Message;
            mobOperator.Calling += Show_Message;

            for (var i = 0; i < 15; i++)
            {
                var random = new Random();
                var outClient = random.Next(0, numOfClients);
                var inClient = random.Next(0, numOfClients);
                var action = random.Next(0, 2);
                switch (action)
                {
                    case (int)Actions.Call:
                        clients[outClient].CallOut(clients[inClient]);
                        break;
                    case (int)Actions.Message:
                        clients[outClient].MessageOut(clients[inClient]);
                        break;
                }
            }
            //clients[0].CallOut(clients[1]);
            //clients[0].CallOut(clients[1]);

            Console.ReadKey();
        }

        private static void Show_Message(string str)
        {
            Console.WriteLine(str);
        }
    }
}