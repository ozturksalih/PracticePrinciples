using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DbModels
{
    public class Plane : IVehicle
    {
        public int Id { get ; set ; }
        public string Brand { get ; set ; }
        public string Colour { get ; set ; }
        public int Power { get ; set ; }
        public int PassengerCapacity { get ; set ; }
        public string EngineType { get; set; }
        public int WingSpan { get; set; }
    }
}
