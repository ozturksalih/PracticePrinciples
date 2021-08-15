using PracticePrinciples.DbModels;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public class TruckDao : DataAccessBase, ITruckDao, IReportDao
    {
        private readonly DbContext _dbContext;
        public TruckDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Truck truck)
        {
            truck.Id = GenerateId(_dbContext.Trucks.Select(t => t.Id));
            _dbContext.Trucks.Add(truck);
        }

        public Truck GetById(int id)
        {
            var truck = _dbContext.Trucks.Single(t => t.Id == id);

            return truck;
        }

        public ICollection<Truck> GetAll()
        {
            return _dbContext.Trucks;
        }

        public void Delete(int id)
        {
            var truck = _dbContext.Trucks.Single(t => t.Id == id);
            _dbContext.Trucks.Remove(truck);
        }

        public int GetTotalPower()
        {
            return _dbContext.Trucks.Sum(t => t.Power);
        }

        public IDictionary<string, int> GetByColours()
        {
            var result = new Dictionary<string, int>();

            var groupByColour = _dbContext
                .Trucks
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
