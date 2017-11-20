using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_2
{
    public static class Extended
    {
        public static void WorkingWithArrayOfString(this Printer printer, string[] list)
        {
            foreach (var el in list)
                printer.Print(el);
        }

        public static void WorkingWithArrayOfStringAndColors(this ColourPrinter colorPrinter, string[] list, ConsoleColor[] color)
        {
            for (var i = 0; i < list.Length; i++)
            {
                var j = i;
                j = j >= color.Length ? 0 : j;
                colorPrinter.Print(list[i], color[j]);
            }
        }

        public static void WorkingWithArrayOfImg(this PhotoPrinter photoPrinter, Img[] imgs)
        {
            foreach (var el in imgs)
            {
                Console.WriteLine("Img");
                photoPrinter.Print(el);
            }
        }
    }
}