using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int CloneValue (int input)
        {
            return input;
        }

        static Wrapped CloneRef(Wrapped input)
        {
            return input;
        }

        static void Main(string[] args)
        {
            
            int val = 10;
            int valCopied;
            Wrapped refe = new Wrapped();
            Wrapped refeCopied;
            valCopied = CloneValue (val);
            refeCopied = CloneRef(refe);

            Console.WriteLine("Value copy {0} {1}", val, valCopied);
            Console.WriteLine("Referense copy {0} {1}", refe, refeCopied);
            

            Console.ReadLine();
        }

    }
}
