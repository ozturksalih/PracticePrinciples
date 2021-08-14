using PracticePrinciples.DbModels;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class CarDao : DataAccessBase ,ICarDao
    {

        private readonly DbContext _dbContext;

        public CarDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Car car)
        {
            car.Id = GenerateId(_dbContext.Cars.Select(c => c.Id));
            _dbContext.Cars.Add(car);
        }

        public Car GetById(int id)
        {
            var car = _dbContext.Cars.Single(t => t.Id == id);

            return car;
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

        public ICollection<Car> GetAll()
        {
            return _dbContext.Cars;
        }


        public void Delete(int id)
        {
            var car = _dbContext.Cars.Single(c => c.Id ==id);
            _dbContext.Cars.Remove(car);
        }
    }
}
