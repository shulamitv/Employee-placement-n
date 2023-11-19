using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class Employee : ControllerBase
    {
        private DataContext context;
        public Employee(DataContext context)
        {
            this.context = context;
        }
        // GET: api/<Employee>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(context.employeeList);

        }
        // GET api/<Employee>/5
        [HttpGet("{experience}")]
        public ActionResult Get(bool experience)
        {
            EmployeeC employee = context.employeeList.Find(x => x.Experience == experience);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        // POST api/<Employee>
        [HttpPost]
        public void Post([FromBody] EmployeeC employee)
        {
            context.employeeList.Add(employee);
        }

        // PUT api/<Employee>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)//עדכון שם עבודה
        {
            context.employeeList.Find(x => x.Id == id).Name = value;
        }

        // DELETE api/<Job>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.employeeList.Remove(context.employeeList.Find(x => x.Id == id));
        }
    }
}
