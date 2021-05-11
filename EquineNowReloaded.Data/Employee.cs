using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public class Employee
    {
        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        public virtual List<Horse> Horses { get; set; } = new List<Horse>();

        public virtual List<Auction> Auctions { get; set; } = new List<Auction>();

        public virtual List<VetCheck> VetChecks { get; set; } = new List<VetCheck>();
    }
}
