using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest_run.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_rest_run.Controllers
{
    [Route("api/[controller]")]
    public class inventoryController : Controller
    {
        // conexion base de datos
        private readonly TestDbContext _context;

        public inventoryController(TestDbContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Inventory> Get()
        {
            // return new string[] { "value1", "value2" };
            return _context.Inventories.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

