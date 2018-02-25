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
    public class CustomerController : Controller
    {
        //static Customer cust = new Customer();
        //
        // GET: /Customer/
        public string GetCustomerDetails()
        {
            List<Employee> empList = new List<Employee>();
            Employee emp = new Employee();
            for(int i=0 ; i<10 ; i++)
            {

                 emp.employeeName ="Emp"+i;
                 emp.employeeAge  =i*5;
                 emp.employeeSalary=i*1000;
                 emp.employeeDesignation ="designation "+i;
                 emp.employeeProject = "Project " + i;
                 empList.Add(emp);
            }
            string json = JsonConvert.SerializeObject(empList, Formatting.Indented);
            return json;
        }

	}
}