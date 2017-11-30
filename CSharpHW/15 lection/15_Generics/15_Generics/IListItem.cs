using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    interface IListItem<T>
    {
        IListItem<T> Previous { set; get; }
        T Data { set; get; }
        IListItem<T> Next { set; get; }
    }
}
