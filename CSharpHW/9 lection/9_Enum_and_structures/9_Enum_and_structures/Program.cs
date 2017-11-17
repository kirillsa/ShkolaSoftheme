using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarConstructor factory = new CarConstructor();
            var car = factory.Construct(Engine.Diesel, Color.Red, Transmission.Mechanic);
            car.ShowInfo();
            car = factory.Reconstract(car);
            car.ShowInfo();
            Console.ReadLine();
        }
    }
}