using System;
using System.Collections.Generic;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobOperator = new Operator();
            mobOperator.OperatorMsg += ServiceMsg;

            List<MobileAccount> clients = new List<MobileAccount>();
            var numOfClients = 5;

            for (uint i = 0; i < numOfClients; i++)
            {
                clients.Add(new MobileAccount (i, "asd", DateTime.Parse("12.12.2000"), "as@fd", mobOperator));
            }

            var random = new Random();
            for (var i = 0; i < 18; i++)
            {
                var outClient = random.Next(0, numOfClients);
                var inClient = random.Next(0, numOfClients);
                if (outClient == inClient)
                {
                    continue;
                }
                var action = random.Next(1, 3);
                switch (action)
                {
                    case (int)MobileAccountActionType.Call:
                        clients[outClient].CallOut(clients[inClient]);
                        break;
                    case (int)MobileAccountActionType.Message:
                        clients[outClient].MessageOut(clients[inClient]);
                        break;
                }
                Console.WriteLine();
            }
            mobOperator.ShowStatistic();
            Console.ReadKey();
        }

        private static void ServiceMsg(string str)
        {
            Console.WriteLine(str);
        }
    }
}