using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Car
    {
        public Car(string model, int year, string color)
        {
            Model = model;
            this.Year = year;
            this.Color = color;
        }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
    static class TuningAtelier
    {
        public static void TuneCar(Car car)
        {
            car.Color = "red";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Lamborgini", 2016, "yellow");
            Console.WriteLine("{0} {1} {2} {3}",car1.ToString(), car1.Model, car1.Year, car1.Color);
            TuningAtelier.TuneCar(car1);
            Console.WriteLine("{0} {1} {2} {3}",car1.ToString(), car1.Model, car1.Year, car1.Color);
            TuningAtelier.TuneCar(car1);
            //TuningAtelier a = new TuningAtelier();
            Console.ReadKey();
        }
    }
}
