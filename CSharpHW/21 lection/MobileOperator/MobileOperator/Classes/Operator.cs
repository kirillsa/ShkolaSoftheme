using System;
using System.Collections.Generic;
using System.Linq;
using MobileOperator.Contracts;

namespace MobileOperator
{
    [Serializable]
    public class Operator : IOperator
    {
        private Dictionary<uint, MobileAccount> _dictOfClients;
        private Dictionary<uint, JournalActionItem> _journalOfActions;

        private static uint id = 0;

        public delegate void ServiceMessage(string str);
        public event ServiceMessage OperatorMsg;

        public Operator()
        {
            _dictOfClients = new Dictionary<uint, MobileAccount> {};
            _journalOfActions = new Dictionary<uint, JournalActionItem> {};
        }

        private bool VerificationNumber(uint number)
        {
            return _dictOfClients.ContainsKey(number) ?
                                                 true :
                                                 false;
        }

        private void Message(MobileAccount sender, MobileAccount receiver)
        {
            OperatorMsg?.Invoke(receiver.MessageIn(sender));

            _journalOfActions.Add(id++, new JournalActionItem()
            {
                Time = DateTime.Now,
                InvokerNumber = sender.MobileNumber,
                ReceiverNumber = receiver.MobileNumber,
                ActionType = MobileAccountActionType.Message
            });
        }

        private void Call(MobileAccount sender, MobileAccount receiver)
        {
            OperatorMsg?.Invoke(receiver.CallIn(sender));

            _journalOfActions.Add(id++, new JournalActionItem()
            {
                Time = DateTime.Now,
                InvokerNumber = sender.MobileNumber,
                ReceiverNumber = receiver.MobileNumber,
                ActionType = MobileAccountActionType.Call
            });
        }

        public void AddClient(MobileAccount account)
        {
            if (!VerificationNumber(account.MobileNumber))
            {
                _dictOfClients.Add(account.MobileNumber, account);
                account.MakeCall += Call;
                account.MakeMessage += Message;
            }
            else
            {
                OperatorMsg?.Invoke("Account is already exists");
            }
        }

        public void ShowStatistic()
        {
            Console.WriteLine();
            var callCost = 1.0;
            var sum = default(double);
            var listOfMostAccounts = new List<ResultStatisticItem>();

            var groupsOfStatisticJournal = from action in _journalOfActions.Values
                                           group action by action.InvokerNumber;

            foreach (var items in groupsOfStatisticJournal)
            {
                sum = 0;
                foreach (var item in items)
                {
                    sum += item.ActionType == MobileAccountActionType.Call ?
                        (double)callCost :
                        callCost / 2;
                }
                listOfMostAccounts.Add(new ResultStatisticItem()
                {
                    Number = items.Key,
                    Sum = sum
                });

            }
            var listOfMostAcountsSorted = from item in listOfMostAccounts
                                          orderby item.Sum descending
                                          select item;
            listOfMostAcountsSorted.Take(5);
            
            Console.WriteLine("The most 5 active accounts");
            foreach (var item in listOfMostAcountsSorted)
            {
                Console.WriteLine($"Number {item.Number} Calls and Messages cost: {item.Sum}");
            }

            groupsOfStatisticJournal = from action in _journalOfActions.Values
                                       group action by action.ReceiverNumber;

            listOfMostAccounts = new List<ResultStatisticItem>();

            foreach (var items in groupsOfStatisticJournal)
            {
                sum = 0;
                foreach (var item in items)
                {
                    sum += item.ActionType == MobileAccountActionType.Call ?
                        (double)callCost :
                        callCost / 2;
                }
                listOfMostAccounts.Add(new ResultStatisticItem()
                {
                    Number = items.Key,
                    Sum = sum
                });

            }
            listOfMostAcountsSorted = from item in listOfMostAccounts
                                      orderby item.Sum descending
                                      select item;
            listOfMostAcountsSorted.Take(5);

            Console.WriteLine();
            Console.WriteLine("The most 5 popular accounts");
            foreach (var item in listOfMostAcountsSorted)
            {
                Console.WriteLine($"Number {item.Number} Calls and Messages cost: {item.Sum}");
            }
        }
    }
}