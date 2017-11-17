using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CarConstructor
    {
        public Car Construct(Engine engine, Color color, Transmission transmission)
        {
            Car car;
            car.engine = engine;
            car.color = color;
            car.transmission = transmission;
            return car;
        }

        public Car Reconstract(Car car)
        {
            car.engine = Engine.Petrol;
            return car;
        }
    }
}