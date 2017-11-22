using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    class NameAuthenticator : IAuthenticator
    {
        public bool AuthenticateUser(IUser user, string pass)
        {
            return user.Password == pass;
        }
    }
}
