using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    class Operator
    {
        public delegate void ServiceMessage(string str);
        public event ServiceMessage OperatorMsg;

        private Dictionary<uint, MobileAccount> _dictOfClients;
        private Dictionary<uint, JournalOfActions> _journalOfActions;

        private static uint id = 0;

        public Operator()
        {
            _dictOfClients = new Dictionary<uint, MobileAccount> ();
            _journalOfActions = new Dictionary<uint, JournalOfActions> ();
        }

        private bool VerificationNumber(uint number)
        {
            return _dictOfClients.ContainsKey(number) ?
                                                 true :
                                                 false;
        }

        private bool InitClients(params MobileAccount[] accounts)
        {
            foreach (MobileAccount account in accounts)
            {
                if (!VerificationNumber(account.GetNumber()))
                {
                    OperatorMsg?.Invoke($"Operator: Unvarified number {account.GetNumber()} detected, we've added it to dictOfClients");
                    AddClient(account);
                }
            }
            return true;
        }

        public void AddClient(MobileAccount account)
        {
            _dictOfClients.Add(account.GetNumber(), account);
            _journalOfActions.Add(account.GetNumber(), new JournalOfActions());
        }

        public void Message(MobileAccount sender, MobileAccount reciever)
        {
            if (InitClients(sender, reciever))
            {
                OperatorMsg?.Invoke(reciever.MessageIn(sender));
                _journalOfActions[sender.GetNumber()].MessageOut++;
                _journalOfActions[reciever.GetNumber()].MessageIn++;
            }
        }

        public void Call(MobileAccount sender, MobileAccount reciever)
        {
            if (InitClients(sender, reciever))
            {
                OperatorMsg?.Invoke(reciever.CallIn(sender));
                _journalOfActions[sender.GetNumber()].CallOut++;
                _journalOfActions[reciever.GetNumber()].CallIn++;
            }
        }

        public void ShowStatistic()
        {
            Console.WriteLine();
            var callCost = 1;
            var statisticJournal = from user in _journalOfActions
                select new
                {
                    Number = user.Key,
                    Popular = (user.Value.CallIn * callCost + (double)user.Value.MessageIn * callCost / 2),
                    Active = (user.Value.CallOut * callCost + (double)user.Value.MessageOut * callCost / 2)
                };

            var mostFamous = statisticJournal;
            mostFamous = from user in mostFamous
                         orderby user.Popular descending 
                         select user;
            mostFamous = mostFamous.Take(5);
            Console.WriteLine("5 most popular accounts:");
            foreach (var user in mostFamous)
            {
                Console.WriteLine($"{user.Number} Calls and Messages cost: {user.Popular:F1}");
            }

            var mostActive = statisticJournal;
            mostActive = from user in mostActive
                         orderby user.Active descending
                         select user;
            mostActive = mostActive.Take(5);
            Console.WriteLine("5 most active accounts:");
            foreach (var user in mostActive)
            {
                Console.WriteLine($"{user.Number} Calls and Messages cost: {user.Active:F1}");
            }
        }
    }
}