using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Boat:Vehicle
    {
        //public string colour = "";
        public string colour { get; set; }

        
        public Boat(string colourboat):base ("Boat")
        {
            this.colour = colourboat;
        }
        public override string DescribeVehicle()
        {
            return "This vehicle is a " + typeofvehicle+", Colour is on the boat: "+colour;
            
        }
    }
}
