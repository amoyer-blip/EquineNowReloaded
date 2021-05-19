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
        public int? HorseId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }
    
        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }
    }
}
