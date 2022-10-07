using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Shell
    {
        private int WeightOfShell { get; set; }
        private int WeightOfFuel { get; set; }
        private int Passengers { get; set; }

        public Shell()
        {
            WeightOfFuel = 40;
            WeightOfShell = 1400;
            Passengers = 2;
        }
        public int SumOfWeight()
        {
            return (75 * Passengers) + WeightOfShell + WeightOfFuel;
        }
    }
}
