using Core;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("{id}")]
        public ActionResult<Clients> Get(int id)
        {
            var result = GetClient(id);
            if (result == null)
                return NotFound();

            return result;
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Clients client)
        {
            var result = GetClient(id);
            if (result == null)
                return NotFound();

            UpdateClient(id, client);
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
