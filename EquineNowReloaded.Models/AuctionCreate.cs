using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class AuctionCreate
    {
        [Required]
        [Display(Name = "Auction Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        public string AuctionName { get; set; }


        [Display(Name = "City and State")]
        public string AuctionLocation { get; set; }


        [Display(Name = "Total Horses")]
        public int TotalHorsesRescued { get; set; }


        [Display(Name = "Date of Auction")]
        public DateTime AuctionDate { get; set; }


    }
}

