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
    public class CarsController : ControllerBase
    {
        private ICarService _carService;
        public CarsController(ICarService iCarService)
        {
            _carService  = iCarService;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _carService.GetAll();
        }

        [HttpGet("{id}")]
        public Car GetById(int id)
        {
            return _carService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Car car)
        {
            _carService.Add(car);
        }

        [HttpDelete]
        public void Sell([FromBody]Car car)
        {
            _carService.Sell(car);
        }
    }
}
