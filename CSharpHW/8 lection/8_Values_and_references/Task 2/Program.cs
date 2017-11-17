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
            Engine engine = new Engine { EngineModel = "turbo" };
            Color color = new Color { ColorModel = "grey" };
            Transmission transmission = new Transmission { TransmissionModel = "mechanics" };
            var factory = new CarConstructor();
            var car = factory.Construct ( engine, color, transmission );
            car.ShowInfo();
            factory.Reconstract(car);
            car.ShowInfo();
            color.ColorModel = "";
            car.ShowInfo();
            Console.ReadLine();
        }
    }
}