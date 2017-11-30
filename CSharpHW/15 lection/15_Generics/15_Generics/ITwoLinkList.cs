using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    interface ITwoLinkList<T>
    {
        void AddFirst(ListItem<T> listItem);
        bool DeleteElement(int pos);
        int CountOfElements();
        bool PresenceOfElement(T value);
        T[] ToArr();
        void ShowList();
    }
}
