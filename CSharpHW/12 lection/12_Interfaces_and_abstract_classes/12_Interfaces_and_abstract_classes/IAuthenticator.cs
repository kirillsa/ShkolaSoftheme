using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    interface IAuthenticator
    {
        User AuthenticateUser(IUser[] user, string name, string email, string password);

    }
}