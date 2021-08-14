using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Entities
{
    public class PlaneRequest : IVehicleRequest
    {
        public string Brand { get; set; }
        public string Colour { get; set; }
        public int Power { get; set; }
        public int PassengerCapacity { get; set; }
        public string EngineType { get; set; }
        public int WingSpan { get; set; }
    }
}
