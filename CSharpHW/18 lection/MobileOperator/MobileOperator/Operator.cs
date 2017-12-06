using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Operator
    {
        public delegate void ServiceMessage(string str);
        public event ServiceMessage Messaging;
        public event ServiceMessage Calling;

        private Dictionary<int, MobileAccount> _dictOfClients;

        MobileAccount instSender;
        MobileAccount instReciever;

        public Operator()
        {
            _dictOfClients = new Dictionary<int, MobileAccount> ();
        }

        private MobileAccount InitClient(int number)
        {
            if (_dictOfClients.ContainsKey(number))
            {
                    return _dictOfClients[number];
            }
        return null;
        }

        private bool IsRealNumbers(int sender, int reciever)
        {
            instSender = InitClient(sender);
            if (instSender is null)
            {
                Messaging.Invoke($"Wrong number of sender {sender}");
                return false;
            }
            else
            {
                instReciever = InitClient(reciever);
                if (instReciever is null)
                { 
                    Messaging.Invoke($"Wrong number of reciever {reciever}");
                    return false;
                }
            }
            return true;
        }

        public void AddClient(int number)
        {
            if (!_dictOfClients.ContainsKey(number))
            {
                _dictOfClients.Add(number, new MobileAccount(number));
            }
        }

        public void Message(int sender, int reciever)
        {
            if (IsRealNumbers(sender, reciever))
            {
                if (Messaging != null)
                { 
                    Messaging.Invoke(instSender.MessageOut(instReciever));
                    Messaging.Invoke(instReciever.MessageIn(instSender));
                }
            }
        }

        public void Call(int sender, int reciever)
        {
            if (IsRealNumbers(sender, reciever))
            {
                if (Calling != null)
                {
                    Calling.Invoke(instSender.CallOut(instReciever));
                    Calling.Invoke(instReciever.CallIn(instSender));
                }
            }
        }
    }
}