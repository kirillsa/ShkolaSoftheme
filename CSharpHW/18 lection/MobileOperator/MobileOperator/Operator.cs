using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Operator
    {
        public delegate void SpecialMessage(string str);
        public event SpecialMessage Messaging;
        public event SpecialMessage Calling;

        private List<MobileAccount> _list;

        MobileAccount instSender;
        MobileAccount instReciever;

        private MobileAccount CheckClient(int num)
        {
            foreach (var el in _list)
            {
                if (el.GetNumber() == num)
                {
                    return el;
                }
            }
            return null;
        }

        public Operator()
        {
            _list = new List<MobileAccount>()
            {
                new MobileAccount(1),
                new MobileAccount(2),
                new MobileAccount(3),
                new MobileAccount(4)
            };
        }
        public void AddClient(int mob)
        {
            if (CheckClient(mob) is null)
            { 
                _list.Add(new MobileAccount(mob));
            }
        }

        public void Message(int sender, int reciever)
        {
            instSender = CheckClient(sender);
            instReciever = CheckClient(reciever);
            if (instSender != null && instReciever != null)
            {
                if (Messaging != null)
                { 
                    Messaging.Invoke(instSender.MessageOut(instReciever));
                    Messaging.Invoke(instReciever.MessageIn(instSender));
                }
            }
            else
            {
                Console.WriteLine("Account is absent");
            }
        }

        public void Call(int sender, int reciever)
        {
            instSender = CheckClient(sender);
            instReciever = CheckClient(reciever);
            if (instSender != null && instReciever != null)
            {
                if (Messaging != null)
                {
                    Messaging.Invoke(instSender.CallOut(instReciever));
                    Messaging.Invoke(instReciever.CallIn(instSender));
                }
            }
            else
            {
                Console.WriteLine("Account is absent");
            }
        }
    }
}
