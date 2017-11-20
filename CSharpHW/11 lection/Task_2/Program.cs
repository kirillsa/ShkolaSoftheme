using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new string[5];
            for (var i = 0; i < 5; i++)
            {
                list[i] = $"Number {i}";
            }
            var colors = new[] { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.DarkYellow };
            var imgs = new Img[4];
            var printer = new Printer();
            printer.WorkingWithArrayOfString(list);
            var colorPrinter = new ColourPrinter();
            colorPrinter.WorkingWithArrayOfStringAndColors(list, colors);
            var photoPrinter = new PhotoPrinter();
            photoPrinter.WorkingWithArrayOfImg(imgs);
            Console.ReadKey();
        }
    }
}