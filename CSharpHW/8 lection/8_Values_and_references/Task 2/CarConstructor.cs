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
            var car = new Car
            {
                engine = engine,
                color = color,
                transmission = transmission
            };
            return car;
        }

        public void Reconstract(Car car)
        {
            car.engine.EngineModel = "Diesel";
        }
    }
}