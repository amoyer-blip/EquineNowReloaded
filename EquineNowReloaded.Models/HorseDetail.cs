using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class HorseDetail
    {
        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Horse's Name")]
        public string HorseName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Auction Id")]
        public int? AuctionId { get; set; }

        [Display(Name = "Auction Name")]
        public string AuctionName { get; set; }
      
        [Display(Name = "Color/Markings")]
        public string Color { get; set; }

        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
