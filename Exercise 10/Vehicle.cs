using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Vehicle
    {
        public string typeofvehicle = "";
        public Vehicle(string model)
        {
            this.typeofvehicle =model;
        }
        public string DescribeVehicle()
        {
            Console.WriteLine("This vehicle is a "+typeofvehicle );
            return "";
        }
    }
}
