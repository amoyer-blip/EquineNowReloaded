using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class AuctionEdit
    {
        [Display(Name = "Auction Id")]
        public int AuctionId { get; set; }

        [Display(Name = "Auction Name")]
        public string AuctionName { get; set; }

        [Display(Name = "Location")]
        public string AuctionLocation { get; set; }

        [Display(Name = "Date of Auction")]
        public DateTimeOffset AuctionDate { get; set; }
    }
}
