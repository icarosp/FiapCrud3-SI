using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudAM.Models;

namespace CrudAM.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}