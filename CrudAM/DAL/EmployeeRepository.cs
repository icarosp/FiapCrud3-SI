using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAM.Models
{
    class EmployeeRepository
    {
        private static EmployeeRepository _repo;

        private EmployeeRepository() {

        }

        public static EmployeeRepository Instance() {
            if (_repo == null) {
                _repo = new EmployeeRepository();
            }

            return _repo;
        }
    }
}
