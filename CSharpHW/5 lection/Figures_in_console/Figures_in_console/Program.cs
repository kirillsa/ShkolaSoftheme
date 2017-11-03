using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_in_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool exitFlag = true;
            while (exitFlag)
            {
                num = int.Parse(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
                for (int i = 0; i < 2*num-1; i++)
                {
                    for (int j = 0; j < 2*num-1; j++)
                    {
                        if ((j-i) < num-1 || (j-i) >= num)
                        {
                            Console.Write("  ");
                        }
                        else
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                /*for (int i = num-1; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }*/
            }
        }
    }
}
