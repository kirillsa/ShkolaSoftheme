using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    class ListItem<T> : IListItem<T>
    {
        public IListItem<T> Previous { set; get; }
        public T Data { set; get; }
        public IListItem<T> Next { set; get; }
    }
}
