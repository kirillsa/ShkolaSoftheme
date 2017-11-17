using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ReArray(10);
            arr.ShowInfo();
            arr.Add(12,13,1,2);
            arr.ShowInfo();
            Console.WriteLine(arr.Contains(12).ToString());
            Console.WriteLine(arr.Contains(999).ToString());
            Console.ReadKey();
        }
    }
}
