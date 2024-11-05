using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsysCompany.Models
{

        [PrimaryKey(nameof(Dnumber), nameof(DLocation))]
        public class DeptLocation
        {
            [ForeignKey("Department")]
            public int Dnumber { get; set; }
            public virtual Department Department { get; set; }

            public string DLocation { get; set; }
        }
}
