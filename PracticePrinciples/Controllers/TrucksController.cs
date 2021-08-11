using Microsoft.AspNetCore.Mvc;
using PracticePrinciples.DataAccess;
using PracticePrinciples.Entities;
using PracticePrinciples.Services;
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
        private ITruckService _truckService;
        public TrucksController(ITruckService iTruckService)
        {
            _truckService = iTruckService;
        }

        [HttpGet]
        public IEnumerable<Truck> Get()
        {
            return _truckService.GetAll();    
        }

        // GET api/<TrucksController>/5
        [HttpGet("{id}")]
        public Truck Get(int id)
        {
            return _truckService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Truck truck)
        {
            _truckService.Add(truck);
        }

      
        [HttpDelete]
        public void Sell(Truck truck)
        {
            _truckService.Sell(truck);
        }
    }
}
