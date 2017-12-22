﻿using System;
using System.Collections.Generic;
using System.IO;
using MobileOperator.Classes;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobOperator = new Operator();
            mobOperator.OperatorMsg += msg => Console.WriteLine(msg); 

            List<MobileAccount> clients = new List<MobileAccount>();
            var numOfClients = 5;
            var inputFile = "people.json";

            if (File.Exists(inputFile))
            {
                clients = Serialization.JSONDeSer(inputFile);
            }
            if (clients.Count == 0)
            {
                for (uint i = 0; i < numOfClients; i++)
                {
                    clients.Add(new MobileAccount(i, "asd", DateTime.Parse("12.12.2000"), "as@fd", mobOperator));
                }
                Serialization.JSONSer(inputFile, clients);
            }



            /*var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                Serialization.JSONSer(inputFile, clients);
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.Ticks);*/

            /*var random = new Random();
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
            
            mobOperator.ShowStatistic();*/

            Console.ReadKey();
        }
    }
}