using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public interface IVehicleDao<T>
    {
        void Add(T vehicle);
        void Sell(T vehicle);
        List<T> ListVehicles();
        T GetById(int id);
    }
}
