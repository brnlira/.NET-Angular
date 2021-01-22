using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PBT.API.Data;
using PBT.API.Model;

namespace PBT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController
    {
        public readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            try
            {
                return _context.Clientes.ToList();
            }
            catch(Exception)
            {
                throw new Exception("Banco de Dados Falhou.");
            } 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            try
            {
                return _context.Clientes.FirstOrDefault(x => x.ClienteId == id);
            }
            catch(Exception)
            {
                throw new Exception("Banco de Dados Falhou.");
            } 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}