using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    class UserDataBase : IUserDataBase
    {
        protected User[] _users = new User[2];

        public User Search(string login)
        {
            for (var i = 0; i < this._users.Length; i++)
            {
                if (this._users[i] != null)
                { 
                    if (this._users[i].Name == login || this._users[i].Email == login)
                    {
                        return this._users[i];
                    }
                }
            }
            return null;
        }

        public void Add(string login, string password)
        {
            var gain = true;
            for (var i = 0; i < this._users.Length; i++)
            { 
                if (this._users[i] == null)
                {
                    this._users[i] = new User(login, password, DateTime.Now);
                    gain = false;
                    break;
                }
            }
            if (gain)
            { 
                var buf = new User[this._users.Length*2];
                for (var i = 0; i < this._users.Length; i++)
                {
                    buf[i] = this._users[i];
                }
                this._users = buf;
                this._users[this._users.Length/2] = new User(login, password, DateTime.Now);
            }
        }

        public void Dispose()
        {
            for (var i = 0; i < this._users.Length; i++)
            {
                if (this._users[i] != null)
                {
                    Console.WriteLine(this._users[i].GetFullInfo());
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}