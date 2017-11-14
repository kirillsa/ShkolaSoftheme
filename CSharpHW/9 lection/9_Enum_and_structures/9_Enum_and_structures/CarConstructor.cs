using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarConstructor
    {
        //Car _car;

        public CarConstructor()//ref Car car)
        {
            //_car = car;
        }

        public void Construct(ref Car car, Engine engine, Color color, Transmission transmission)
        {
            car._engine = engine.ToString();
            car._color = color.ToString();
            car._transmission = transmission.ToString();
            //return car;
        }

        public void Reconstract(ref Car car)
        {
            car._engine = Engine.Petrol.ToString();
        }

        /*public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", _car._engine, _car._color, _car._transmission);
        }*/

    }
}