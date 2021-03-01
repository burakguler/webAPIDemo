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
           new Employee{Id=1, ad="Burak",soyAd="Güler"},
           new Employee{Id=1, ad="Burak",soyAd="Gülmez"},
           new Employee{Id=1, ad="Burak",soyAd="Gülür"},

       };

        public IEnumerable<Employee> GetEmployees()
        {
            return listEmployees;
        }

        // GET: api/Employee
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Employee/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
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
