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
        public int VetCheckId { get; set; }

        [Display(Name = "HorseId")]
        public int? HorseId { get; set; }

        public Guid EmployeeId { get;  }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
