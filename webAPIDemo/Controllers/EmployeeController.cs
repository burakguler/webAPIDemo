using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPIDemo.Models;

namespace webAPIDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        private List<Employee> listEmployees = new List<Employee>
       {
           new Employee{Id=1, name="Burak",lastName="Güler"},
           new Employee{Id=2, name="Burak",lastName="Gülmez"},
           new Employee{Id=3, name="Burak",lastName="Gülür"},

       };

        public IEnumerable<Employee> GetEmployees()
        {
            return listEmployees;
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var wantedEmployee = (from e in listEmployees
                                  where e.Id == id
                                  select e).FirstOrDefault();
            return Ok(wantedEmployee);
        }

        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (listEmployees.Where(p=>p.Id==employee.Id).Count()==0)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
