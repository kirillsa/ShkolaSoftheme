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
            //Car car = new Car("turbo","red","auto");
            Engine engine = new Engine ("Turbo");
            Color color = new Color ("Red");
            Transmission transmission = new Transmission ("Auto");
            Car car = new Car();
            CarConstructor factory = new CarConstructor(car);
            factory.Construct(engine, color, transmission);
            car.ShowInfo();
            factory.Reconstract(car);
            car.ShowInfo();
            factory.ShowInfo();
            Console.ReadLine();
        }
    }
}