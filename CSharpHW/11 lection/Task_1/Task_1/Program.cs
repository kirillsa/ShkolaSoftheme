using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print("text");
            Img img = new Img();
            photoPrinter.Print(img);
            ColourPrinter colourPrinter = new ColourPrinter();
            colourPrinter.Print("text");
            colourPrinter.Print("colored text", ConsoleColor.DarkGreen);
            Console.ReadKey();
        }
    }
}