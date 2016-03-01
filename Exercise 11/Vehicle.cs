using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    abstract class Vehicle
    {
        public string typeofvehicle = "";
        public string vehicle { get; set; }



        public Vehicle(string model)
        {
            this.typeofvehicle =model;
        }
        public virtual string DescribeVehicle()//lämnar info till overriden
        {
            return "This vehicle is a "+vehicle;
            
        }
        
        

    }
}
