using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MobileOperator.Contracts;

namespace MobileOperator
{
    class MobileAccount : IMobileAccount, IValidatableObject
    {
        private Dictionary<int, string> _contactsDictionary;
        public uint MobileNumber { get; private set; }

        public delegate void MakeAction(MobileAccount sender, MobileAccount receiver);
        public event MakeAction MakeCall;
        public event MakeAction MakeMessage;

        private void AddContactToDictionary(MobileAccount incomeAccount)
        {
            Console.Write("Enter the name for number {0} in dictionary of {1}: ", incomeAccount.MobileNumber, MobileNumber);
            _contactsDictionary.Add((int)incomeAccount.MobileNumber, Console.ReadLine());
        }

        private string ActionOut(MobileAccount outcome, string msg)
        {
            return String.Format("{0} {1} {2}", MobileNumber, msg, outcome.MobileNumber);
        }

        private string ActionIn(MobileAccount income, string msg)
        {
            var info = string.Format("{0} {1} ", MobileNumber, msg);

            var existContact = _contactsDictionary.Any(u => u.Key == income.MobileNumber);
            if (existContact)
            {
                info += string.Format("{0}", _contactsDictionary[(int)income.MobileNumber]);
            }
            else
            {
                AddContactToDictionary(income);
                info += string.Format("{0}", income.MobileNumber);
            }
            return info;
        }

        public MobileAccount(uint mob, Operator mobOperator)
        {
            MobileNumber = mob;
            var myOperator = mobOperator;
            myOperator.AddClient(this);
            _contactsDictionary = new Dictionary<int, string>();

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine($"Пользователь {MobileNumber} не прошел валидацию из-за:");
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine($"Пользователь {MobileNumber} прошел валидацию");
            }
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (this.MobileNumber < 1 || this.MobileNumber > 5)
            { 
                errors.Add(new ValidationResult("Недопустимый номер телефона"));
            }
            return errors;
        }
    }
}