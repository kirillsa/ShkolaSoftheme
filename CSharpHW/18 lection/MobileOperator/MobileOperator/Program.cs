using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobOperator = new Operator();
            for (var i = 0; i < 5; i++)
            {
                mobOperator.AddClient(i);
            }

            mobOperator.Messaging += Show_Message;
            mobOperator.Calling += Show_Message;
            mobOperator.Message(1, 3);
            mobOperator.Message(1, 3);
            mobOperator.Call(4,3);
            mobOperator.Call(9,9);

            Console.ReadKey();
        }

        private static void Show_Message(string str)
        {
            Console.WriteLine(str);
        }
    }
}