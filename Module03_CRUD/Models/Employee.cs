using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Module03_CRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        [ForeignKey("Company")]
        [Display(Name ="Company: ")]
        public int CompanyId  { get; set; }
        public virtual Company Company { get; set; }
        public Employee()
        {

        }
    }
}
