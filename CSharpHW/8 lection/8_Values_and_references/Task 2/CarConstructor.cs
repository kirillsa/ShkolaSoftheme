using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarConstructor
    {
        Car _car;

        public CarConstructor( Car car )
        {
            
            _car = car;
        }

        public void Construct(Engine engine, Color color, Transmission transmission)
        {
            _car._engine = engine._engine;
            _car._color = color._color;
            _car._transmission = transmission._transmission;
        }

        public void Reconstract(Car car)
        {
            car._engine = "Diesel";
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", _car._engine, _car._color, _car._transmission);
        }

    }
}