using EquineNowReloaded.Data;
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
        public int AuctionId { get; set; }

        [Display(Name = "Auction Name")]
        public string AuctionName { get; set; }

 
        [Display(Name = "City and State")]
        public string AuctionLocation { get; set; }


        [Display(Name = "Total Horses")]
        public int TotalHorsesRescued { get; set; }


        [Display(Name = "Date of Auction")]
        public DateTime AuctionDate { get; set; }

        public int? HorseId { get; set; }

        public virtual List<Horse> Horses { get; set; } = new List<Horse>();
    }
}
