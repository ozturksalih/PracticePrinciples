using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Entities
{
    public class Truck : IWheeledVehicle
    {
        public int Id { get ; set ; }
        public string Brand { get ; set ; }
        public string Colour { get ; set ; }
        public int Power { get ; set ; }
        public int PassengerCapacity { get ; set ; }
        public string TransmissionType { get; set; }
        public int NumberOfWheels { get; set; }
        public string TrailerType { get; set; }
    }
}
