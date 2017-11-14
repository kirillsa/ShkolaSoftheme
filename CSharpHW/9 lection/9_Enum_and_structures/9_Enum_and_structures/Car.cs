using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Car
    {
        public string _engine;
        public string _color;
        public string _transmission;

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", _engine, _color, _transmission);
        }
    }
}