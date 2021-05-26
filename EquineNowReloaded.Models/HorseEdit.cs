using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class HorseEdit
    {
        //[Required]
        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Horse's Name")]
        public string HorseName { get; set; }

        [Display(Name = "Immediate Medical")]
        public bool ImmediateMedical { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Display(Name = "Color/Markings")]
        public string Color { get; set; }

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

    }
}
