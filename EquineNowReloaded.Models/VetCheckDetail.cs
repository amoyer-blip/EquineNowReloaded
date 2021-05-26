using EquineNowReloaded.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class VetCheckDetail
    {
        [Display(Name = "Vet Check Id")]
        public int VetCheckId { get; set; }

        [Display(Name = "Horse Id")]
        public int? HorseId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        public virtual Horse Horse{get; set;}
        public Guid EmployeeId { get;  }

        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
