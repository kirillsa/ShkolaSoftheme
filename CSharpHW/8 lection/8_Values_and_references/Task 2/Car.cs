using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Car
    {
        public Engine engine;
        public Color color;
        public Transmission transmission;

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1} {2}", engine.EngineModel, color.ColorModel, transmission.TransmissionModel);
        }
    }
}