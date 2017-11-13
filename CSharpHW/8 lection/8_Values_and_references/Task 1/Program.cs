using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void IncValue(ref int i)
        {
            i++;
        }

        static void DecOut(out int i)
        {
            i = 15;
        }

        static void Main(string[] args)
        {
            
            int buf = 10;
            int bufCopied;
            bufCopied = buf;
            buf = 11;
            Console.WriteLine("Value copy {0} {1}", buf, bufCopied);
            bufCopied = buf;
            IncValue(ref buf);
            Console.WriteLine("Value copy {0} {1}", buf, bufCopied);
            
            Console.ReadLine();
        }

    }
}
