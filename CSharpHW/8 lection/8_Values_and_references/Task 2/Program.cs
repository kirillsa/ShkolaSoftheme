using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Car
    {
        public Engine engine;
        public Color color;
        public Transmission transmission;
        /*public Car (string eng, string col, string transm)
        { 
            engine = new Engine (eng);
            color = new Color(col);
            transmission = new Transmission(transm);
        }*/
    }

    class Engine
    {
        public string _engine;
        public Engine(string eng)
        {
            _engine = eng;
        }
    }

    class Color
    {
        public string _color;
        public Color(string col)
        {
            _color = col;
        }
    }

    class Transmission
    {
        public string _transmission;
        public Transmission(string transm)
        {
            _transmission = transm;
        }
    }

    public class CarConstructor
    {
        Car car;
        public void Construct(string engine, string color, string transmission)
        {
            car.engine = new Engine (engine);
            car.color = new Color(color);
            car.transmission = new Transmission(transmission);
            //car = new Car(engine, color, transmission);
            //return car;
        }
        void Reconstract()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("turbo","red","auto");
            Car car1 = CarConstructor
            Console.WriteLine("{0} {1} {2}",car.engine._engine, car.color._color, car.transmission._transmission);
            Console.ReadLine();
        }
    }
}
