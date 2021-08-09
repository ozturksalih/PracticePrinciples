using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Entities
{
    public interface IVehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public int Power { get; set; }
        public int PassengerCapacity { get; set; }
    }
}
