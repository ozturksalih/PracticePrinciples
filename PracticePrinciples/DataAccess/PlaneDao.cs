using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class PlaneDao : IPlaneDao
    {

        private readonly List<Plane> planes = new()
        {
            new Plane {Id=4,Brand="Boeing",Colour="White",EngineType="Pervaneli",PassengerCapacity=150,Power=25550,WingSpan=10 },
            new Plane { Id = 5, Brand = "Boeing", Colour = "Blue", EngineType = "Pervanesiz", PassengerCapacity = 25, Power = 25550, WingSpan = 7 }        };
        public void Add(Plane vehicle)
        {
            planes.Add(vehicle);
        }

        public Plane GetById(int id)
        {
            var plane = planes.Single(t => t.Id == id);

            return plane;
        }

        public ICollection<Plane> GetAll()
        {
            return planes;
        }

        public void Delete(Plane vehicle)
        {


            planes.Remove(vehicle);    
        }
    }
}
