﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;
using MobileOperator.Classes;

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
                clients.Add(new MobileAccount(i, "asd", DateTime.Parse("12.12.2000"), "as@fd", mobOperator));
            }
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                Serialization.BinSer(clients); //85 818 167 ticks
                //Serialization.XMLSer(clients); //98 003 365 ticks
                Serialization.JSONSer(clients); //92 222 985 ticks
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.Ticks);
            

            Console.ReadKey();

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
        }

        private static void ServiceMsg(string str)
        {
            Console.WriteLine(str);
        }
    }
}