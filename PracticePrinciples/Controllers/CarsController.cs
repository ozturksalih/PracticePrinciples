using Microsoft.AspNetCore.Mvc;
using PracticePrinciples.DataAccess;
using PracticePrinciples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PracticePrinciples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarDao _carDao;
        public CarsController(ICarDao iCarDao)
        {
            _carDao = iCarDao;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _carDao.ListVehicles();
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carDao.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _carDao.Add(car);
        }

        [HttpDelete]
        public void Delete([FromBody]Car car)
        {
            _carDao.Sell(car);
        }
    }
}
