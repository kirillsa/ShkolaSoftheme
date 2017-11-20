using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    class Program
    {
        static string login;
        static string email;
        static string password;
        public static IUser[] users;

        static void Clear()
        {
            var login = "";
            var email = "";
            var password = "";
            Console.Clear();
        }

        static void Main(string[] args)
        {
            users = new User[10];
            var authenticator = new Authenticator();
            do
            {
                Clear();
                try
                {
                    Console.WriteLine("Enter your name:");
                    login = Console.ReadLine();
                    login.Trim(' ');
                    if (login == "" || login == "e")
                    {
                        Console.WriteLine("Enter your email:");
                        email = Console.ReadLine();
                        email.Trim(' ');
                        if (!email.Contains("@") && email != "e")
                        {
                            Console.WriteLine("wrong email!");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    Console.WriteLine("Enter your password:");
                    password = Console.ReadLine();
                    password.Trim(' ');
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    continue;
                }
                if (login == "e" && email == "e" && password == "e")
                {
                    break;
                }
                var user = authenticator.AuthenticateUser(users, login, email, password);
                if (user != null )
                {
                    Console.WriteLine("This user was here for last time at {0}", user.Time);
                    user.Time = DateTime.Now;
                    Console.ReadKey();
                }
            }
            while (true);
            /*for (var i = 0; i < users.Length; i++ )
            {
                //IUser user = new (IUser) users[i];
                Console.WriteLine(value: users[i].GetFullInfo());
            }*/
            foreach (var el in users)
            {
                el.GetFullInfo();
            }
            Console.ReadKey();
        }
    }
}
