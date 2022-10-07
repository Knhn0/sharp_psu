using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class FirstEngine : IEngine
    {
        public int Weight { get; }
        public int Power { get; }

        public void Start()
        {
            Console.WriteLine("Двигатель запускается");
        }
        public void Stop()
        {
            Console.WriteLine("Двигатель заглушен");
        }
        public FirstEngine()
        {
            Weight = 100;
            Power = 150;
        }
    }
}
