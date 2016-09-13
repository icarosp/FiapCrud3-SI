using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAM.Models;

namespace CrudAM.Repository
{
    public class EmployeeRepository
    {
        private static EmployeeRepository _repo;
        private List<Employee> employees;

        private EmployeeRepository() {
            this.employees = new List<Employee>();
        }

        public static EmployeeRepository Instance() {
            if (_repo == null) {
                _repo = new EmployeeRepository();
            }

            return _repo;
        }

        public void Create(Employee emp) {
            this.employees.Add(emp);
        }

        public IEnumerable<Employee> ListEmployees() {
            return this.employees;
        }

        public Employee ListEmployees(int id)
        {
            return this.employees.Where(x => x.id == id).First();
        }

        public void DeleteEmployee(int id) {
            this.employees.RemoveAll(x => x.id == id);
        }

        public void EditEmployee(Employee emp)
        {
            this.employees.RemoveAll(x => x.id == emp.id);
            this.employees.Add(emp);
        }
    }
}
