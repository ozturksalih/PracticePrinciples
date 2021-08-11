using PracticePrinciples.DataAccess;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    public class CarManager : ICarService
    {
        private readonly ICarDao _carDao;
        public CarManager(ICarDao iCarDao)
        {
            _carDao = iCarDao;
        }

        public void Add(Car car)
        {
            _carDao.Add(car);
        }

        public void Sell(Car t)
        {
            
        }

        public ICollection<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public Car GetById(int id)
        {
            var car = _carDao.GetById(id);
            return car;
        }
    }
}
