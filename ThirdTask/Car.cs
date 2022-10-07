using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Car
    {
        public Shell Shell { get; set; }
        public IEngine FirstEngine { get; set; }
        public int CarWeight
        {
            get
            {
                return FirstEngine.Weight + Shell.SumOfWeight();
            }
        }

    }


}

