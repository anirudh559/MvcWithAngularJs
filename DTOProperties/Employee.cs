using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProperties
{
    public class Employee
    {
        [Required]
        public string employeeName { get; set; }
        
        [Required]
        public int employeeAge { get; set; }
        
        [Required]
        public float employeeSalary { get; set; }

        [Required]
        public string employeeDesignation { get; set; }

        [Required]
        public string employeeProject { get; set; }

    }
}
