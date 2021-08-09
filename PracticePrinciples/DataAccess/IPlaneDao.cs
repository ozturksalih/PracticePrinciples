using System;
using System.Linq;
using PracticePrinciples.Entities;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public interface IPlaneDao:IVehicleDao<Plane>
    {
    }
}
