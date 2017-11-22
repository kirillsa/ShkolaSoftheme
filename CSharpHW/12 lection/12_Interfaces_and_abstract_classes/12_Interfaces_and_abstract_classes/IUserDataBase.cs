using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Interfaces_and_abstract_classes
{
    interface IUserDataBase : IDisposable
    {
        User Search(string login);
        void Add(string login, string password);
        void Dispose();
    }
}
