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
        private Dictionary<int, string> _contactsOfAccount;

        public MobileAccount(int mob)
        {
            _mobileNumber = mob;
            this._contactsOfAccount = new Dictionary<int, string>();
        }

        public int GetNumber()
        {
            return _mobileNumber;
        }

        public string CallOut(MobileAccount callingTo)
        {
            return string.Format("{0} is calling to {1}",_mobileNumber, callingTo.GetNumber());
        }

        public string CallIn(MobileAccount callFrom)
        {
            if (_contactsOfAccount.ContainsKey(callFrom.GetNumber()))
            {
                return string.Format("{0} recieve call from {1}", _mobileNumber, _contactsOfAccount[callFrom.GetNumber()]);
            }
            else
            {
                Console.WriteLine("Enter the name for number {0} in dictionary of {1}", callFrom.GetNumber(), _mobileNumber);
                _contactsOfAccount.Add(callFrom.GetNumber(), Console.ReadLine());
                return string.Format("{0} recieve call from {1}", _mobileNumber, callFrom.GetNumber());
            }
        }

        public string MessageOut(MobileAccount messageTo)
        {
            return String.Format("{0} is messaging to {1}", _mobileNumber, messageTo.GetNumber());
        }

        public string MessageIn(MobileAccount messageFrom)
        {
            if (_contactsOfAccount.ContainsKey(messageFrom.GetNumber()))
            {
                return string.Format("{0} recieve message from {1}", _mobileNumber, _contactsOfAccount[messageFrom.GetNumber()]);
            }
            else
            {
                Console.WriteLine("Enter the name for number {0} in dictionary of {1}", messageFrom.GetNumber(), _mobileNumber);
                _contactsOfAccount.Add(messageFrom.GetNumber(), Console.ReadLine());
                return string.Format("{0} recieve message from {1}", _mobileNumber, messageFrom.GetNumber());
            }
        }
    }
}
