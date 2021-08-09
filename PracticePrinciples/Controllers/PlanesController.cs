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
    public class PlanesController : ControllerBase
    {

        private IPlaneDao _planeDao;
        public PlanesController(IPlaneDao iPlaneDao)
        {
            _planeDao = iPlaneDao;
        }
        // GET: api/<PlanesController>
        [HttpGet]
        public IEnumerable<Plane> GetAll()
        {
            return _planeDao.ListVehicles();
        }

        // GET api/<PlanesController>/5
        [HttpGet("{id}")]
        public Plane Get(int id)
        {
            return _planeDao.GetById(id);
        }

        // POST api/<PlanesController>
        [HttpPost]
        public void Post([FromBody] Plane plane)
        {
            _planeDao.Add(plane);
        }

        [HttpDelete("{id}")]
        public void Delete(Plane plane)
        {
            _planeDao.Sell(plane);
        }
    }
}
