using PracticePrinciples.DataAccess;
using PracticePrinciples.DbModels;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    public class TruckManager : ITruckService
    {

        private readonly ITruckDao _truckDao;
        public TruckManager(ITruckDao truckDao)
        {
            _truckDao = truckDao;
        }
        public void Add(Truck truck)
        {
            _truckDao.Add(truck);
        }

        public ICollection<Truck> GetAll()
        {
            return _truckDao.GetAll();
        }

        public Truck GetById(int id)
        {
            return _truckDao.GetById(id);
        }

        public void Sell(int id)
        {
            _truckDao.Delete(id);
        }
    }
}
