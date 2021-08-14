using PracticePrinciples.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class DbContext
    {
        public DbContext()
        {
            Cars = new List<Car>();
            Planes = new List<Plane>();
            Trucks = new List<Truck>();
        }
        public ICollection<Car> Cars { get; set; }
        public ICollection<Plane> Planes { get; set; }
        public ICollection<Truck> Trucks { get; set; }
    }
}
