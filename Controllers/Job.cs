using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebApplication1;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace WebApplication1.Controllers.Job
{

    [Route("api/[controller]")]
    [ApiController]
    public class Job : ControllerBase
    {
        private DataContext context;
        public Job(DataContext context)
        {
            this.context = context;
        }


        // GET: api/<Job>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(context.jobsList);

        }


        // GET api/<Job>/5
        [HttpGet("{Profession}")]
        public ActionResult Get(string profession)
        {
            JobC job = context.jobsList.Find(x => x.Profession == profession);
            if (job == null)
                return NotFound();
            return Ok(job);
        }

        // POST api/<Job>
        [HttpPost]
        public void Post([FromBody] JobC job)
        {
            context.jobsList.Add(job);
        }

        // PUT api/<Job>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)//עדכון שם עבודה
        {
            context.jobsList.Find(x => x.Id == id).Name = value;
        }

        // DELETE api/<Job>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.jobsList.Remove(context.jobsList.Find(x => x.Id == id));
        } 
    }
}
