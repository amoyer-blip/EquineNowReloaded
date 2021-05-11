using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public class VetCheck
    {
        [ForeignKey(nameof(Horse))]
        public int HorseId { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Required]
        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
