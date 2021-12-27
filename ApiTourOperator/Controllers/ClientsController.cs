using Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Core.DataAccess;

namespace ApiTourOperator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Clients> Get()
        {
            return GetClients();
        } 

        [HttpGet("{id_Client}")]
        public ActionResult<Clients> Get(int id)
        {
            var result = GetClient(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPut("{id_Client}")]
        public IActionResult Update(int id, Clients client)
        {
            var result = GetClient(id);
            if (result == null)
                return NotFound();

            UpdateClient(id, client);
            return NoContent();
        }

        [HttpDelete("{id_Client}")]
        public IActionResult Delete(int id)
        {
            var result = GetClient(id);
            if (result == null)
                return NotFound();

            DeleteClient(result);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Create(Clients client)
        {
            AddNewClient(client);
            return NoContent();
        }
    }
}
