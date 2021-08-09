using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class TruckDao : ITruckDao
    {

        private readonly List<Truck> trucks = new()
        {
            new Truck { Id = 1, Brand = "Volvo", Colour = "Red", PassengerCapacity = 2, Power = 750, TransmissionType = "Automatic" },
            new Truck { Id = 2, Brand = "Scanic", Colour = "Orange", PassengerCapacity = 2, Power = 550, TransmissionType = "Manuel" },
            new Truck { Id = 3, Brand = "Tesla", Colour = "White", PassengerCapacity = 7, Power = 550, TransmissionType = "Automatic" }
        };
        public void Add(Truck vehicle)
        {
            trucks.Add(vehicle);
        }

        public Truck GetById(int id)
        {
            foreach (var item in trucks)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Truck> ListVehicles()
        {
            return trucks;
        }

        public void Sell(Truck vehicle)
        {
            trucks.Remove(vehicle);    
        }
    }
}
