﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithAngularJs.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployees()
        {
            return View();
        }

        public ActionResult SaveEmployeDeailsPage()
        {
            return View();
        }
	}
}