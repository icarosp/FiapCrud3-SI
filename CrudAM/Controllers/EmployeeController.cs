using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudAM.Models;
using CrudAM.Repository;

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
            EmployeeRepository repo = EmployeeRepository.Instance();

            repo.Create(emp);

            return RedirectToAction("List");
        }

        public ActionResult List()   
        {
            EmployeeRepository repo = EmployeeRepository.Instance();
            return View(repo.ListEmployees());
        }

        public ActionResult Delete(int id) {
            EmployeeRepository repo = EmployeeRepository.Instance();
            repo.DeleteEmployee(id);
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id) {
            EmployeeRepository repo = EmployeeRepository.Instance();
            Employee emp = repo.ListEmployees(id);
            return View("Create", emp);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            EmployeeRepository repo = EmployeeRepository.Instance();
            repo.EditEmployee(emp);
            return RedirectToAction("List");
        }
    }
}