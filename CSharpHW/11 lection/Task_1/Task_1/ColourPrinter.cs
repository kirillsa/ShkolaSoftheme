using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class ColourPrinter : Printer
    {
        public override void Print(string s)
        {
            Console.WriteLine("Color Printer");
            base.Print(s);
        }

        public void Print(string s, ConsoleColor color)
        {
            var buf = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = buf;
        }
    }
}
