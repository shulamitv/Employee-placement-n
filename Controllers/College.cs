using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class College : ControllerBase
    {
        private DataContext context;
        public College(DataContext context)
        {
            this.context = context;
        }
        // GET: api/<College>
        [HttpGet]
        public ActionResult  Get()
        {
            return Ok(context.collegeList); 
        }

        // GET api/<College>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            CollegeC college = context.collegeList.Find(x => x.Id == id);
            if (college == null)
                return NotFound();
            return Ok(college);
        }

        // POST api/<College>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{

        //}

        // PUT api/<College>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)//עדכון שם עבודה
        {
            context.collegeList.Find(x => x.Id == id).Name = value;
        }

        // DELETE api/<College>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.collegeList.Remove(context.collegeList.Find(x => x.Id == id));
        }
    }
}
