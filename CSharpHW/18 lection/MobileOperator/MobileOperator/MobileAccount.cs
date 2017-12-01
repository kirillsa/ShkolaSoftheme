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
        private Dictionary<int, string> dictionary;

        public MobileAccount(int mob)
        {
            _mobileNumber = mob;
            this.dictionary = new Dictionary<int, string>();
        }

        public string CallOut(MobileAccount mobile)
        {
            return string.Format("{0} is calling to {1}",_mobileNumber, mobile.GetNumber());
        }

        public string CallIn(MobileAccount mobile)
        {
            if (dictionary.ContainsKey(mobile.GetNumber()))
            {
                return string.Format("{0} recieve call from {1}", _mobileNumber, dictionary[mobile.GetNumber()]);
            }
            else
            {
                Console.WriteLine("Enter the name for number {0} in dictionary of {1}", mobile.GetNumber(), _mobileNumber);
                dictionary.Add(mobile.GetNumber(), Console.ReadLine());
                return string.Format("{0} recieve call from {1}", _mobileNumber, mobile.GetNumber());
            }
        }

        public string MessageOut(MobileAccount mobile)
        {
            return String.Format("{0} is messaging to {1}", _mobileNumber, mobile.GetNumber());
        }

        public string MessageIn(MobileAccount mobile)
        {
            if (dictionary.ContainsKey(mobile.GetNumber()))
            {
                return string.Format("{0} recieve message from {1}", _mobileNumber, dictionary[mobile.GetNumber()]);
            }
            else
            {
                Console.WriteLine("Enter the name for number {0} in dictionary of {1}", mobile.GetNumber(), _mobileNumber);
                dictionary.Add(mobile.GetNumber(), Console.ReadLine());
                return string.Format("{0} recieve message from {1}", _mobileNumber, mobile.GetNumber());
            }
        }

        public int GetNumber()
        {
            return _mobileNumber;
        }
    }
}
