using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiService.Models;
using Newtonsoft.Json;
using DTOProperties;

namespace WebApiService.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : System.Web.Http.ApiController
    {
        //static Customer cust = new Customer();
        //
        // GET: /Customer/
       [Route("CustomerDetails")]
        [HttpGet]
        public List<Employee> GetCustomerDetails()
        {
            List<Employee> empList = new List<Employee>();
            for(int i=0 ; i<=10 ; i++)
            {
                Employee emp = new Employee();
                 emp.employeeName ="Emp"+i;
                 emp.employeeAge  =i*5;
                 emp.employeeSalary=i*1000;
                 emp.employeeDesignation ="designation "+i;
                 emp.employeeProject = "Project " + i;
                 empList.Add(emp);
            }
            string json = JsonConvert.SerializeObject(empList, Formatting.Indented);
            return empList;
        }

	}
}