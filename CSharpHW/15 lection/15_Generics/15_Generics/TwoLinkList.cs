using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    class TwoLinkList<T> : ITwoLinkList<T>
    {
        private ListItem<T> _head;

        public void AddFirst(ListItem<T> listItem)
        {
            if (_head is null)
            {
                _head = listItem;
            }
            else
            {
                listItem.Next = _head;
                _head.Previous = listItem;
                _head = listItem;
            }
        }
        public bool DeleteElement(int pos)
        {
            if (_head is null || pos < 0)
            {
                return false;
            }
            var node = _head;
            var nodePrev = _head;
            while (pos > 0)
            {
                if (node.Next is null)
                {
                    return false;
                }
                nodePrev = node;
                node = (ListItem<T>)node.Next;
                pos--;
            }
            if (node.Next is null)
            {
                nodePrev.Next = null;
            }
            else if (node.Previous is null)
            {
                node = (ListItem<T>)node.Next;
                node.Previous = null;
                _head = node;
            }
            else
            {
                nodePrev.Next = node.Next;
            }
            return true;
        }
        public int CountOfElements()
        {
            var count = 0;
            if (_head is null)
            {
                return count;
            }
            var node = _head;
            while (node.Next != null)
            {
                count++;
                node = (ListItem<T>)node.Next;
            }
            return ++count;
        }
        public bool PresenceOfElement(T value)
        {
            if (_head is null)
            {
                return false;
            }
            var node = _head;
            while (node != null)
            {
                if (node.Data.Equals(value))
                {
                    return true;
                }
                if (node.Next != null)
                {
                    node = (ListItem<T>)node.Next;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
       
        public T[] ToArr()
        {
            var node = _head;
            if (node is null)
            {
                return null;
            }
            var n = this.CountOfElements();
            T[] list = new T[n];
            for (var i = 0; i < n; i++)
            {
                list[i] = node.Data;
                node = (ListItem<T>)node.Next;
            }
            return list;
        }

        public void ShowList()
        {
            if (_head != null)
            {
                var node = _head;
                do
                {
                    Console.Write($"{node.Data} ");
                    node = (ListItem<T>)node.Next;
                }
                while (node != null);
            }
            else
            {
                Console.Write("List is empty");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
