using System;
using System.Linq;
using PracticePrinciples.Entities;
using System.Threading.Tasks;
using PracticePrinciples.DbModels;

namespace PracticePrinciples.DataAccess
{
    public interface IPlaneDao:IVehicleDao<Plane>
    {
    }
}
