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
    public class TrucksController : ControllerBase
    {
        private ITruckDao _truckDao;
        public TrucksController(ITruckDao iTruckDao)
        {
            _truckDao = iTruckDao;
        }

        [HttpGet]
        public IEnumerable<Truck> Get()
        {
            return _truckDao.ListVehicles();    
        }

        // GET api/<TrucksController>/5
        [HttpGet("{id}")]
        public Truck Get(int id)
        {
            return _truckDao.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Truck truck)
        {
            _truckDao.Add(truck);
        }

      
        [HttpDelete]
        public void Delete(Truck truck)
        {
            _truckDao.Sell(truck);
        }
    }
}
