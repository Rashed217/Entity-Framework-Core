using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsysCompany.Models
{
    public class Employee
    {

        [Key]
        public int SSN { get; set; }

        [Required]
        public string Fname { get; set; }

        public string Minit { get; set; }

        [Required]
        public string Lname { get; set; }

        public DateTime Bdate { get; set; }

        public  string Address { get; set; }

        public string Sex { get; set; }

        public decimal Salary { get; set; }



        [ForeignKey("Supervisor")]
        public int? SuperSSN { get; set; }
        public virtual Employee Supervisor { get; set; }


        [ForeignKey("Department")]
        public int Dno { get; set; }
        public virtual Department Department { get; set; }


        public virtual ICollection<Dependent> Dependents { get; set; }

        [InverseProperty("Supervisor")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<WorksOn> WorksOnProjects { get; set; }
    }
}
