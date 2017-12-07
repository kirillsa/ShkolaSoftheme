using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    class Operator
    {
        public delegate void ServiceMessage(string str);
        public event ServiceMessage OperatorMsg;

        private Dictionary<int, MobileAccount> _dictOfClients;
        private Dictionary<int, JournalOfActions> _journalOfActions;

        public Operator()
        {
            _dictOfClients = new Dictionary<int, MobileAccount> ();
            _journalOfActions = new Dictionary<int, JournalOfActions> ();
        }

        private bool VerificationNumber(int number)
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
                    OperatorMsg?.Invoke($"Operator: New number {account.GetNumber()} detected, we added it to dictOfClients");
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
            var mostFamous = from user in _journalOfActions
                select new
                {
                    Number = user.Key,
                    Popular = (double)(user.Value.CallIn * callCost + (double)user.Value.MessageIn * callCost / 2)
                };
            mostFamous = from user in mostFamous
                         orderby user.Popular descending 
                         select user;
            mostFamous = mostFamous.Take(5);
            Console.WriteLine("5 most popular accounts:");
            foreach (var user in mostFamous)
            {
                Console.WriteLine($"{user.Number} Calls and Messages cost: {user.Popular:F1}");
            }

            var mostActive = _journalOfActions.Select(user => new
                {
                    Number = user.Key,
                    Popular = (user.Value.CallOut * callCost + (double)user.Value.MessageOut * callCost / 2)
                });
            mostActive = from user in mostActive
                         orderby user.Popular descending
                         select user;
            mostActive = mostActive.Take(5);
            Console.WriteLine("5 most active accounts:");
            foreach (var user in mostActive)
            {
                Console.WriteLine($"{user.Number} Calls and Messages cost: {user.Popular:F1}");
            }
        }
    }
}