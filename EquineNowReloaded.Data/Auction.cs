using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public class Auction //This is the main db, Horse, VetCheck and Employee will be built off of Auction
    {
        [Required]
        public int AuctionId { get; set; }

        [Required]
        [Display(Name = "Auction Name")]
        public string AuctionName { get; set; }

        [Required]
        [Display(Name = "City and State")]
        public string AuctionLocation { get; set; }

        [Required]
        [Display(Name = "Total Horses")]
        public int TotalHorsesRescued { get; set; }

        [Required]
        [Display(Name = "Date of Auction")]
        public DateTime AuctionDate { get; set; }

        public virtual List<Horse> Horses { get; set; } = new List<Horse>();

        [ForeignKey(nameof(Horse))]
        public int HorseId { get; set; }
    }
}
