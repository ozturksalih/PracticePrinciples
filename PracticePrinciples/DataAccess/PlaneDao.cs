using PracticePrinciples.DbModels;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class PlaneDao : DataAccessBase, IPlaneDao, IReportDao
    {
        private readonly DbContext _dbContext;
        public PlaneDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Plane plane)
        {
            plane.Id = GenerateId(_dbContext.Planes.Select(p => p.Id));
            _dbContext.Planes.Add(plane);
        }

        public Plane GetById(int id)
        {
            var plane = _dbContext.Planes.Single(t => t.Id == id);

            return plane;
        }

        public ICollection<Plane> GetAll()
        {
            return _dbContext.Planes;
        }

        public void Delete(int id)
        {
            var plane = _dbContext.Planes.Single(p => p.Id == id);

            _dbContext.Planes.Remove(plane);
        }

        public int GetTotalPower()
        {
            return _dbContext.Planes.Sum(p => p.Power);
        }

        public IDictionary<string, int> GetByColours()
        {
            var result = new Dictionary<string, int>();

            var groupByColour = _dbContext
                .Planes
                .GroupBy(c => c.Colour)
                .Select(c => new { Key = c.Key, Value = c.Count() });
            foreach (var item in groupByColour)
            {
                result.Add(item.Key, item.Value);
            }
            return result;

        }
    }
}
