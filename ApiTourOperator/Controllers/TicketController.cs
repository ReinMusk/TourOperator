using Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Core.DataAccess;

namespace ApiTourOperator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return GetTickets();
        }

        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            var result = GetTicket(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = GetTicket(id);
            if (result == null)
                return NotFound();

            DeleteTicket(result);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            AddNewTicket(ticket);
            return NoContent();
        }
    }
}
