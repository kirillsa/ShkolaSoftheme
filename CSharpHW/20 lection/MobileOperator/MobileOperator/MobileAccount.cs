using System;
using System.Collections.Generic;
using System.Linq;

namespace MobileOperator
{
    class MobileAccount
    {
        private readonly int _mobileNumber;
        private readonly Operator _myOperator;
        private Dictionary<int, string> _contactsBook;

        public delegate void MakeAction(MobileAccount sender, MobileAccount reciever);

        public event MakeAction MakeCall;
        public event MakeAction MakeMessage;

        public MobileAccount(int mob, Operator myOperator)
        {
            _mobileNumber = mob;
            _myOperator = myOperator;
            MakeCall += _myOperator.Call;
            MakeMessage += _myOperator.Message;
            _contactsBook = new Dictionary<int, string>();
        }

        public int GetNumber()
        {
            return _mobileNumber;
        }

        private void AddContact(MobileAccount incomeAccount)
        {
            Console.WriteLine("Enter the name for number {0} in dictionary of {1}", incomeAccount.GetNumber(), _mobileNumber);
            _contactsBook.Add(incomeAccount.GetNumber(), Console.ReadLine());
        }

        public void CallOut(MobileAccount callingTo)
        {
            Console.WriteLine(ActionOut(callingTo, "is calling to"));
            MakeCall?.Invoke(this, callingTo);
        }

        public void MessageOut(MobileAccount messageTo)
        {
            Console.WriteLine(ActionOut(messageTo, "is messaging to"));
            MakeMessage?.Invoke(this, messageTo);
        }

        public string CallIn(MobileAccount callFrom)
        {
            return ActionIn(callFrom, "recieve call from");
        }

        public string MessageIn(MobileAccount messageFrom)
        {
            return ActionIn(messageFrom, "recieve message from");
        }

        private string ActionOut(MobileAccount outcome, string msg)
        {
            return String.Format("{0} {1} {2}", _mobileNumber, msg, outcome.GetNumber());
        }

        private string ActionIn(MobileAccount income, string msg)
        {
            var info = string.Format("{0} {1} ", _mobileNumber, msg);

            var existContact = _contactsBook.Any(u => u.Key == income.GetNumber());
            if (existContact)
            {
                info += string.Format("{0}", _contactsBook[income.GetNumber()]);
            }
            else
            {
                AddContact(income);
                info += string.Format("{0}", income.GetNumber());
            }
            return info;
        }
    }
}