using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    class Authenticator : IAuthenticator
    {
        public User AuthenticateUser(IUser[] users, string name, string email, string password)
        {
            for (var i = 0; i < users.Length; i++)
            {
                if (users[i] is null)
                {
                    users[i] = new User(name, email, password, DateTime.Now);
                    Console.WriteLine("You are a new user!");
                    Console.ReadKey();
                    return null;
                }
                else if ((users[i].Name == name || users[i].Email == email) && users[i].Password == password)
                {
                    //Console.WriteLine(users[i].GetFullInfo());
                    return (User)users[i];
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
    }
}
