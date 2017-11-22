using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Time { get; set; }

        public User(string name, string password, DateTime time)
        {
            if (name.Contains('@'))
            {
                Email = name;
            }
            else
            {
                Name = name;
            }
            Password = password;
            Time = time;
        }

        public string GetFullInfo()
        {
            var login = Name == null ? " email: " + Email : " name: " + Name;
            return "User's info is: " + login + " password: "+ Password;
        }
    }
}