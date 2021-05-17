using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class HorseCreate
    {
        [Required]
        [Display(Name = "Horse's Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(30, ErrorMessage = "There are too many characters in this field.")]
        public string HorseName { get; set; }

        [Display(Name = "Needs Urgent Care")]
        public bool ImmediateMedical { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }
        
        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Required]
        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        public int? AuctionId { get; set; }

        [Display(Name = "Auction")]
        public string AuctionName { get; set; }
    }
}
