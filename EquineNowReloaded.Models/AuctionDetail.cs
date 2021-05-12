using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class AuctionDetail
    {
        [Key]
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
    }
}
