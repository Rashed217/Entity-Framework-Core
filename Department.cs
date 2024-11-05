using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsysCompany.Models
{
    public class Department
    {

        [Key]
        public int Dnumber { get; set; }

        [Required]
        public string Dname { get; set; }

        [ForeignKey("Manager")]
        public int MgrSSN { get; set; }

        public virtual Employee Manager { get; set; }

        public DateTime MgrStartDate { get; set; }



        public virtual ICollection<DeptLocation> Locations { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
