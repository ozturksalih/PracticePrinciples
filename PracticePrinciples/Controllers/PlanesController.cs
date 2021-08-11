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
    public class PlanesController : ControllerBase
    {

        private IPlaneService _planeService;
        public PlanesController(IPlaneService iPlaneService)
        {
            _planeService = iPlaneService;
        }
        // GET: api/<PlanesController>
        [HttpGet]
        public IEnumerable<Plane> GetAll()
        {
            return _planeService.GetAll();
        }

        // GET api/<PlanesController>/5
        [HttpGet("{id}")]
        public Plane Get(int id)
        {
            return _planeService.GetById(id);
        }

        // POST api/<PlanesController>
        [HttpPost]
        public void Post([FromBody] Plane plane)
        {
            _planeService.Add(plane);
        }

        [HttpDelete("{id}")]
        public void Sell(Plane plane)
        {
            _planeService.Sell(plane);
        }
    }
}
