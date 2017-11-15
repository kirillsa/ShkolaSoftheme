using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class PhotoPrinter : Printer
    {
        public PhotoPrinter()
        {
        }
        public override void Print(string s)
        {
            Console.WriteLine("Photo Printer");
            base.Print(s);
        }

        public void Print(Img img)
        {
            Console.WriteLine("input img");
            this.Print("photo printer");
        }
    }
}
