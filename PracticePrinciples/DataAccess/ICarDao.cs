using PracticePrinciples.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public interface ICarDao : IVehicleDao<Car>
    {
        //IEnumerable<Car> GroupByColour();
    }
}
