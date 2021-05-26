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
        [Key]
        public int VetCheckId { get; set; }

        [ForeignKey(nameof(Horse))]
        public int? HorseId { get; set; }
        public virtual Horse Horse { get; set; }

        //[Required]
        public Guid EmployeeId { get; set; }

        [Required]
        [Display(Name = "Needs Urgent Care")]
        public bool ImmediateMedical { get; set; }

        [Required]
        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Required]
        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Required]
        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
