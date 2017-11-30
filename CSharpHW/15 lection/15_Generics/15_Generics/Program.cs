using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new TwoLinkList<int>();
            for (var i = 0; i < 6; i++)
            {
                var node = new ListItem<int>
                {
                    Data = i
                };
                list.AddFirst(node);
            }
            list.ShowList();
            if (list.DeleteElement(4))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not deleted");
            }
            list.ShowList();
            Console.WriteLine($"{list.CountOfElements()}");
            Console.ReadKey();
            if (list.PresenceOfElement(0))
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            Console.ReadKey();
            var arr = list.ToArr();
            foreach (var el in arr)
            {
                Console.Write("{0} ", el);
            }
            Console.ReadKey();
        }
    }
}
