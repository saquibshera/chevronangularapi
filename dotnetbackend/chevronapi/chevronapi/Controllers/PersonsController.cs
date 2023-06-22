using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chevronapi.Models;
using chevronapi.Repository;
using chevronapi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chevronapi.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly Myrepo _dtcon;

        public PersonsController(Myrepo dtcon)
        {
            this._dtcon = dtcon;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> getpersons()
        {
            return _dtcon.getperson();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Addperson([FromBody]Person per)
        {
            var person = new Person
            {
                Id = per.Id,
                Name = per.Name,
                Address = per.Address,
                Email = per.Address
            };
            _dtcon.Addperson(person);
           
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
            _dtcon.delete(id);
        }
    }
}

