using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsysCompany.Models
{
    [PrimaryKey(nameof(Essn), nameof(DependentName))]
    public class Dependent
    {
        [ForeignKey("Employee")]

        public int Essn { get; set; }

        public virtual Employee Employee { get; set; }
        public string DependentName { get; set; }
        public string Sex { get; set; }

        public DateTime Bdate { get; set; }

        public string Relationship { get; set; }
    }
}
