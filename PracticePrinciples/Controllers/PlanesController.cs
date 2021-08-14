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
    public class PlanesController : ControllerBase
    {

        private IPlaneService _planeService;
        public PlanesController(IPlaneService iPlaneService)
        {
            _planeService = iPlaneService;
        }
        // GET: api/<PlanesController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_planeService.GetAll());
        }

        // GET api/<PlanesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_planeService.GetById(id));
        }

        // POST api/<PlanesController>
        [HttpPost]
        public IActionResult Post([FromBody] PlaneRequest request)
        {
            var plane = new Plane
            {
                Brand = request.Brand,
                Colour = request.Colour,
                EngineType = request.EngineType,
                PassengerCapacity = request.PassengerCapacity,
                Power = request.Power,
                WingSpan = request.WingSpan
            };
            _planeService.Add(plane);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Sell(int id)
        {
            _planeService.Sell(id);
            return Ok();
        }
    }
}
