using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicledata = new VehicleData();
            Car car = new Car();
            Boat boat = new Boat("");
            vehicledata.PrintVehicle(car);


        }
    }
}
