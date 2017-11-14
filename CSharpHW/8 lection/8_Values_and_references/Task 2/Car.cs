using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Car
    {
        public string _engine;
        public string _color;
        public string _transmission;
        /*public Car (Engine eng, Color col, Transmission transm)
        { 
            _engine = eng._engine;
            _color = col._color;
            _transmission = transm._transmission;
        }*/
        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", _engine, _color, _transmission);
        }
    }
}