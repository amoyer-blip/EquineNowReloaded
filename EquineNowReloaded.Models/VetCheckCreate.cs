using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class VetCheckCreate
    {
        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Display(Name = "Injuries")]
        public string Injury { get; set; }
    }
}
