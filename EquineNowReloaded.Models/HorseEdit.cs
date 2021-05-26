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
        public int HorseId { get; set; }

        public string HorseName { get; set; }

        public bool ImmediateMedical { get; set; }
  
        public string IntakeNotes { get; set; }
        
        public string Injury { get; set; }
     
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

        //public string AuctionName { get; set; }
    }
}
