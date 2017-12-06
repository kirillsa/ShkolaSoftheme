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
        private Dictionary<int, int[]> _journalOfActions;

        MobileAccount instSender;
        MobileAccount instReciever;

        public Operator()
        {
            _dictOfClients = new Dictionary<int, MobileAccount> ();
            _journalOfActions = new Dictionary<int, int[]> ();
        }

        private MobileAccount VerificationNumber(int number)
        {
            return _dictOfClients.ContainsKey(number) ?
                        _dictOfClients[number] :
                        null;
        }

        private bool InitClients(MobileAccount sender, MobileAccount reciever)
        {
            instSender = VerificationNumber(sender.GetNumber());
            if (instSender is null)
            {
                Messaging.Invoke($"Operator: Unknown number of sender {sender.GetNumber()} we added it");
                AddClient(sender.GetNumber(), sender);
                instSender = VerificationNumber(sender.GetNumber());
            }
            instReciever = VerificationNumber(reciever.GetNumber());
            if (instReciever is null)
            { 
                Messaging.Invoke($"Operator: Unknown number of reciever {reciever.GetNumber()} we added it");
                AddClient(reciever.GetNumber(), reciever);
                instReciever = VerificationNumber(reciever.GetNumber());
            }
            return true;
        }

        public void AddClient(int number, MobileAccount account)
        {
            _dictOfClients.Add(number, account);
            _journalOfActions.Add(number, new int[4]);
        }

        public void Message(MobileAccount sender, MobileAccount reciever)
        {
            if (InitClients(sender, reciever))
            {
                if (Messaging != null)
                { 
                    Messaging.Invoke(instReciever.MessageIn(instSender));
                }
                _journalOfActions[sender.GetNumber()][(int)JournalActions.MessageOut]++;
                _journalOfActions[reciever.GetNumber()][(int)JournalActions.MessageIn]++;
            }
        }

        public void Call(MobileAccount sender, MobileAccount reciever)
        {
            if (InitClients(sender, reciever))
            {
                if (Calling != null)
                {
                    Calling.Invoke(instReciever.CallIn(instSender));
                }
                _journalOfActions[sender.GetNumber()][(int)JournalActions.CallOut]++;
                _journalOfActions[reciever.GetNumber()][(int)JournalActions.CallIn]++;
            }
        }

        public void ShowStatistic()
        {
            var cost = 1;
            var mostFamous = from user in _journalOfActions
                             select new { user.Key, sum(user.Value[(int)JournalActions.CallIn]*cost + user.Value[(int)JournalActions.MessageIn] * cost/2) }
            //var mostActive
        }
    }
}