using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.Services
{
    public interface IVehicleService<T>
    {
        void Add(T t);
        ICollection<T> GetAll();

        T GetById(int id);
        void Sell(int id);
    }
}
