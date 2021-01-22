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
    public class CSessaoController
    {
        public readonly DataContext _context;

        public CSessaoController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CSessao>> Get()
        {
            try
            {
                return _context.CSessao.ToList();
            }
            catch(Exception)
            {
                throw new Exception("Banco de Dados Falhou.");
            } 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<CSessao> Get(int id)
        {
            try
            {
                return _context.CSessao.FirstOrDefault(x => x.Id == id);
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