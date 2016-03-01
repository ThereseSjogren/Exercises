using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vehicledata = new VehicleData();
            Car car = new Car();
            Boat boat = new Boat("");
            
            car.vehicle = "Car";
            car.typeofvehicle = "Sportscar";
            boat.typeofvehicle = "Sailboat";
            boat.colour = "Red";

            Console.WriteLine(car.DescribeVehicle());
            Console.WriteLine(boat.DescribeVehicle());
            car.engineIsRunning= true;
            if(car.engineIsRunning)
            {
                Console.WriteLine("Engine is running");
            }
            else
            {
                Console.WriteLine("Engine is stopped");
            }


        }
    }
}
