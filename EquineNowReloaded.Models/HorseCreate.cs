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

        [Required]
        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        [Display(Name = "Auction Id")]
        public int? AuctionId { get; set; }

    }
}
