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

        public User(string name, string email, string password, DateTime time)
        {
            Name = name;
            Email = email;
            Password = password;
            Time = time;
        }

        public string GetFullInfo()
        {
            return "User info is: "+ Name +" "+ Email +" "+ Password;
        }
    }
}