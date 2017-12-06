using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class MobileAccount
    {
        private readonly int _mobileNumber;
        private readonly Operator _myOperator;
        private Dictionary<int, string> _contactsOfAccount;

        public MobileAccount(int mob, Operator myOperator)
        {
            _mobileNumber = mob;
            _myOperator = myOperator;
            //_myOperator.Calling = 
            _contactsOfAccount = new Dictionary<int, string>();
        }

        public int GetNumber()
        {
            return _mobileNumber;
        }

        private void AddContact(MobileAccount incomeAccount)
        {
            Console.WriteLine("Enter the name for number {0} in dictionary of {1}", incomeAccount.GetNumber(), _mobileNumber);
            _contactsOfAccount.Add(incomeAccount.GetNumber(), Console.ReadLine());
        }

        public void CallOut(MobileAccount callingTo)
        {
            Console.WriteLine(ActionOut(callingTo, "is calling to"));
            _myOperator.Call(this, callingTo);
        }

        public void MessageOut(MobileAccount messageTo)
        {
            Console.WriteLine(ActionOut(messageTo, "is messaging to"));
            _myOperator.Message(this, messageTo);
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
            return String.Format("{0} {2} {1}", _mobileNumber, outcome.GetNumber(), msg);
        }

        private string ActionIn(MobileAccount income, string msg)
        {
            var info = string.Format("{0} {1} ", _mobileNumber, msg);
            //var existContact = from contact in _contactsOfAccount
            //                   where _contactsOfAccount.ContainsKey(income.GetNumber())
            //                   select contact;
            //if (existContact.Count == 0)
                if (_contactsOfAccount.ContainsKey(income.GetNumber()))
            {
                info += string.Format("{0}", _contactsOfAccount[income.GetNumber()]);
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