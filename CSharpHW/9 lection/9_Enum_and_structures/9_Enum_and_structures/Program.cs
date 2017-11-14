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
            Car car;// = new Car();
            car._engine = "";
            car._color = "";
            car._transmission = "";
            CarConstructor factory = new CarConstructor();
            factory.Construct(ref car, Engine.Diesel, Color.red, Transmission.mechanic);
            car.ShowInfo();
            factory.Reconstract(ref car);
            car.ShowInfo();
            //factory.ShowInfo();
            Console.ReadLine();
        }
    }
}