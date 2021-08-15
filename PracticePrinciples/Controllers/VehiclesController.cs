using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticePrinciples.Controllers
{
    using Services;
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        
        private readonly IReportService _reportService;

        public VehiclesController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        [Route("get-total-power")]
        public IActionResult GetTotalPower()
        {
            return Ok(_reportService.GetTotalPower());
        }

        [HttpGet]
        [Route("get-colours")]
        public IActionResult GetByColour()
        {
            return Ok(_reportService.GetByColour());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
