using Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Core.DataAccess;

namespace ApiTourOperator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return GetFlights();
        }

        [HttpGet("{id}")]
        public ActionResult<Flight> Get(int id)
        {
            var result = GetFlight(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = GetFlight(id);
            if (result == null)
                return NotFound();

            DeleteFlight(result);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Flight flight)
        {
            AddNewFlight(flight);
            return NoContent();
        }
    }
}
