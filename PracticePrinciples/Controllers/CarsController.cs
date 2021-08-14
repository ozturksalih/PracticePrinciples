using Microsoft.AspNetCore.Mvc;
using PracticePrinciples.DataAccess;
using PracticePrinciples.DbModels;
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
        public IActionResult GetAll()
        {
            return Ok(_carService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_carService.GetById(id));
        }

        [HttpPost]
        public void Post([FromBody] CarRequest request)
        {
            var car = new Car
            {
                Brand = request.Brand,
                Colour = request.Colour,
                PassengerCapacity = request.PassengerCapacity,
                Power = request.Power,
                TransmissionType = request.TransmissionType
            };
            _carService.Add(car);
        }

        [HttpDelete]
        public IActionResult Sell(int id)
        {
            _carService.Sell(id);
            return Ok();
        }
    }
}
