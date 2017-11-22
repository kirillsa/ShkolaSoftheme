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
        static string password;

        static void Clear()
        {
            var login = "";
            var password = "";
            Console.Clear();
        }

        static string InfoAndInputText(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        static void ShowUsers(User[] users)
        {
            for (var i = 0; i < users.Length; i++)
            {
                if (users[i] != null)
                { 
                Console.WriteLine(users[i].GetFullInfo());
                }
            }
        }
        
        static void Main(string[] args)
        {
            var users = new User[10];
            var nameAuthenticator = new NameAuthenticator();
            var emailAuthenticator = new EmailAuthenticator();
            do
            {
                Clear();
                try
                {
                    login = InfoAndInputText("Enter your login:");
                    login.Trim(' ');
                    if (login == "")
                    {
                        InfoAndInputText("wrong login");
                        continue;
                    }
                    password = InfoAndInputText("Enter your password:");
                    password.Trim(' ');
                }
                catch (Exception ex)
                {

                    InfoAndInputText(ex.Message);
                    continue;
                }
                if (login == "e" && password == "e")
                {
                    break;
                }
                for (var i = 0; i < users.Length; i++)
                {
                    if (users[i] is null)
                    {
                        users[i] = new User(login, password, DateTime.Now);
                        InfoAndInputText("You are a new user!");
                        break;
                    }
                    else if (users[i].Name == login || users[i].Email == login)
                    {
                        var auth = login.Contains('@') ? emailAuthenticator.AuthenticateUser(users[i], password) : nameAuthenticator.AuthenticateUser(users[i],password);
                        if (auth)
                        {
                            InfoAndInputText($"This user was here for last time at {users[i].Time}");
                            users[i].Time = DateTime.Now;
                            break;
                        }
                        else
                        {
                            InfoAndInputText("Wrong password");
                            break;
                        }
                    }
                }
            }
            while (true);
            ShowUsers(users);
            Console.ReadKey();
        }
    }
}