using Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Core.DataAccess;

namespace ApiTourOperator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Tours> Get()
        {
            return GetTours();
        }

        [HttpGet("{id_Tours}")]
        public ActionResult<Tours> Get(int id)
        {
            var result = GetTour(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPut("{id_Tours}")]
        public IActionResult Update(int id, Tours tour)
        {
            var result = GetTour(id);
            if (result == null)
                return NotFound();

            UpdateTour(id, tour);
            return NoContent();
        }

        [HttpDelete("{id_Tours}")]
        public IActionResult Delete(int id)
        {
            var result = GetTour(id);
            if (result == null)
                return NotFound();

            DeleteTour(result);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Tours tour)
        {
            AddNewTour(tour);
            return NoContent();
        }
    }
}
