using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using MobileOperator.Contracts;

namespace MobileOperator
{
    [DataContract]
    [Serializable]
    public class MobileAccount : IMobileAccount, IValidatableObject
    {
        [DataMember]
        public Dictionary<int, string> contactsDictionary;
        //public XmlSerializableDictionary<int, string> contactsDictionary;

        [DataMember]
        public uint MobileNumber { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime DateBirth { get; set; }

        [DataMember]
        public string EMail { get; set; }
        
        public delegate void MakeAction(MobileAccount sender, MobileAccount receiver);

        public event MakeAction MakeCall;

        public event MakeAction MakeMessage;

        private void AddContactToDictionary(MobileAccount incomeAccount)
        {
            Console.Write("Enter the name for number {0} in dictionary of {1}: ", incomeAccount.MobileNumber, MobileNumber);
            contactsDictionary.Add((int)incomeAccount.MobileNumber, Console.ReadLine());
        }

        private string ActionOut(MobileAccount outcome, string msg)
        {
            return String.Format("{0} {1} {2}", MobileNumber, msg, outcome.MobileNumber);
        }

        private string ActionIn(MobileAccount income, string msg)
        {
            var info = string.Format("{0} {1} ", MobileNumber, msg);

            var existContact = contactsDictionary.Any(u => u.Key == income.MobileNumber);
            if (existContact)
            {
                info += string.Format("{0}", contactsDictionary[(int)income.MobileNumber]);
            }
            else
            {
                AddContactToDictionary(income);
                info += string.Format("{0}", income.MobileNumber);
            }
            return info;
        }

        public MobileAccount()
        {
        }

        public MobileAccount(uint mob, string name, DateTime dateTime, string eMail, Operator mobOperator)
        {
            MobileNumber = mob;
            Name = name;
            DateBirth = dateTime;
            EMail = eMail;
            var myOperator = mobOperator;
            myOperator.AddClient(this);
            contactsDictionary = new Dictionary<int, string>();
            //contactsDictionary = new XmlSerializableDictionary<int, string>();

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                Console.WriteLine($"Пользователь {MobileNumber} не прошел валидацию из-за:");
                foreach (var error in results)
                {
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

            if (string.IsNullOrWhiteSpace(Name))
            {
                errors.Add(new ValidationResult("Не допустимое имя"));
            }

            if (EMail == null || !EMail.Contains("@"))
            {
                errors.Add(new ValidationResult("Недопустимый E-mail"));
            }

            if (DateBirth== null || DateBirth.Year < 1980)
            {
                errors.Add(new ValidationResult("Не допустимый год рождения"));
            }
            return errors;
        }
    }
}