using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Car:Vehicle
    {
        public bool engineIsRunning{ get; set; }
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
        public override string DescribeVehicle()// skriver över basklassen + att man kan lägga till saker
        {
            var result= base.DescribeVehicle()+ "This car is a " + typeofvehicle;
            return result;
        }

    }
       
    
}
