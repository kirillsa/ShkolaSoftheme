using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MobileOperator
{
    class MobileAccount : IValidatableObject
    {
        private readonly uint _mobileNumber;
        private readonly Operator _myOperator;
        private Dictionary<int, string> _contactsBook;

        public delegate void MakeAction(MobileAccount sender, MobileAccount reciever);
        public event MakeAction MakeCall;
        public event MakeAction MakeMessage;

        public MobileAccount(uint mob, Operator myOperator)
        {
            _mobileNumber = mob;
            _myOperator = myOperator;
            MakeCall += _myOperator.Call;
            MakeMessage += _myOperator.Message;
            _contactsBook = new Dictionary<int, string>();

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine($"Пользователь {_mobileNumber} не прошел валидацию из-за:");
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine($"Пользователь {_mobileNumber} прошел валидацию");
            }
        }

        private void AddContact(MobileAccount incomeAccount)
        {
            Console.WriteLine("Enter the name for number {0} in dictionary of {1}", incomeAccount.GetNumber(), _mobileNumber);
            _contactsBook.Add((int)incomeAccount.GetNumber(), Console.ReadLine());
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
                info += string.Format("{0}", _contactsBook[(int)income.GetNumber()]);
            }
            else
            {
                AddContact(income);
                info += string.Format("{0}", income.GetNumber());
            }
            return info;
        }

        public uint GetNumber()
        {
            return _mobileNumber;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (this._mobileNumber < 1 || this._mobileNumber > 5)
            { 
                errors.Add(new ValidationResult("Недопустимый номер телефона"));
            }
            return errors;
        }
    }
}