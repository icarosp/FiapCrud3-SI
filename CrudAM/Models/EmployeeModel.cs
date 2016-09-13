using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudAM.Models
{
    public class Employee
    {

        [Display(Name = "Id")]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }

    }
}
