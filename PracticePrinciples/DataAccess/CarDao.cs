using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class CarDao :ICarDao
    {

        private readonly List<Car> cars = new()
        {
            new Car { Id= 1, Brand = "Volkswagen" , Colour = "Red" , PassengerCapacity = 5 , Power = 150,TransmissionType="Automatic"},
            new Car { Id = 2, Brand = "Toyota", Colour = "Blue", PassengerCapacity = 10, Power = 100, TransmissionType = "Manuel" },
            new Car { Id = 3, Brand = "Tesla", Colour = "White", PassengerCapacity = 7, Power = 550, TransmissionType = "Automatic" }
        };
        public void Add(Car vehicle)
        {
            cars.Add((Car)vehicle);
            
        }

        public Car GetById(int id)
        {
            foreach (var item in cars)
            {
                if(item.Id == id)
                {
                    return (Car)item;
                }
            }
            return null;
        }

        //public IEnumerable<Car> GroupByColour()
        //{
        //    Dictionary<int, string> groups;
        //    for (int i = 0; i < cars.Count; i++)
        //    {
        //        for (int j = i; j < cars.Count; j++)
        //        {
        //            if(cars[i].Colour.Equals( cars[j].Colour))
        //            {
        //                groups.Add(1, cars[i].Colour);
        //            }
        //        }
        //    }
        //}

        public List<Car> ListVehicles()
        {
            return cars;
        }


        public void Sell(Car vehicle)
        {
            cars.Remove((Car)vehicle);
        }
    }
}
