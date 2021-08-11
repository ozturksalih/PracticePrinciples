using PracticePrinciples.DataAccess;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    public class PlaneManager : IPlaneService
    {
        private readonly IPlaneDao _planeDao;
        public PlaneManager(IPlaneDao planeDao)
        {
            _planeDao = planeDao;
        }
        public void Add(Plane plane)
        {
            _planeDao.Add(plane);
        }

        public ICollection<Plane> GetAll()
        {
            return _planeDao.GetAll();
        }

        public Plane GetById(int id)
        {
            return _planeDao.GetById(id);
        }

        public void Sell(Plane plane)
        {
            _planeDao.Delete(plane);
        }
    }
}
