using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Motorcycle, Spaceship, Tractor, SUV, Boat, FlyingBison }
    public class Vehicle
    {
        //1 Access Modifier
        //2 Type
        //3 Name
        //4 Getters and Setters
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }

        //have to actually add the enum to your class
        public VehicleType TypeOfVehicle { get; set; }
    }
}
