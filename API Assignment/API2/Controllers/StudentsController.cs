using API2.Context;
using API2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public CRUDContext cursor;
        public ValuesController(CRUDContext Cursor)
        {
            this.cursor = Cursor;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public List<Student> Get()
        {
            var items = new List<Student> { };
            var data = cursor.Students;

            foreach (var item in data) {
                items.Add(item);

            }
            return items;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return cursor.Students.SingleOrDefault(x => x.Student_ID == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            cursor.Students.Add(value);
            cursor.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            cursor.Students.Update(value);
            cursor.SaveChanges();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var val = cursor.Students.FirstOrDefault(x => x.Student_ID == id);
            if (val != null)
            {
                cursor.Students.Remove(val);
                cursor.SaveChanges();
            }
        }
    }
}
