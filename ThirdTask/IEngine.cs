using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    interface IEngine
    {
        void Start();
        void Stop();
        int Weight { get; }
        int Power { get; }

    }
}
