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
        [Display(Name = "HorseId")]
        public int HorseId { get; set; }
    
        public string HorseName { get; set; }
     
        [Display(Name = "Needs Urgent Care")]
        public bool ImmediateMedical { get; set; }
     
        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }
        
        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        public int? AuctionId { get; set; }

        [Display(Name = "Auction")]
        public string AuctionName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
