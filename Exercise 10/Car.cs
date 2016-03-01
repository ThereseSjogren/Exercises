using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Car:Vehicle
    {
        public bool engineIsRunning;
        public Car():base("Car")
        {
            engineIsRunning = false;
        }

        public void StartEngine()
        {
            engineIsRunning = true;
        }

        public void StopEngine()
        {
            engineIsRunning = false;
        }

    }
       
    
}
