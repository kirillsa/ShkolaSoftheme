using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_in_console
{
    class Program
    {
        static void Triangle(int dim)
        {
            var str = "";
            for (int i = 0; i < dim; i++)
            {
                Console.WriteLine(str += "* ");
            }
        }

        static void Square(int dim)
        {
            var str = "";
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }

        static void Romb(int dim)
        {
            var str = "";
            var midDim = dim / 2;
            if (dim % 2 == 1)
            {
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (i <= midDim)
                        {
                            if (j < (midDim - i) || (midDim + i) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                        else
                        {
                            if (j < (midDim + i - dim + 1) || (midDim - i + dim - 1) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                    }
                    Console.Write("\n");
                }
            }
            else
            {
                for (int i = 0; i < dim; i++)
                {
                    for (int j = 0; j < dim; j++)
                    {
                        if (i <= midDim)
                        {
                            if (j < (midDim - i - 1) || (midDim + i) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                        else
                        {
                            if (j < (midDim + i - dim) || (midDim - i + dim - 1) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                    }
                    Console.Write("\n");
                }
            }
        }

        static void Main(string[] args)
        {
            var dim = 0;
            var figure = "";
            var exitFlag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Type \"q\" for exit");
                Console.WriteLine("Choose the figure you want to see: t - for triangle, s - for square, r - for romb");
                figure = Console.ReadLine();
                if (figure == "q")
                {
                    exitFlag = false;
                    continue;
                }
                if (figure != "t" && figure != "s" && figure != "r")
                {
                    continue;
                }
                Console.WriteLine("Enter the dimension of the figure:");
                try
                {
                    dim = int.Parse(Console.ReadLine());
                    switch (figure)
                    {
                        case "t":
                            Triangle(dim);
                            break;
                        case "s":
                            Square(dim);
                            break;
                        case "r":
                            Romb(dim);
                            break;
                    }
                    Console.Write("Press enter");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (exitFlag);
        }
    }
}
