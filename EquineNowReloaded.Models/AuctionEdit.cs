using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class AuctionEdit
    {
        public int AuctionId { get; set; }

        public string AuctionName { get; set; }

        public string AuctionLocation { get; set; }

        public int TotalHorsesRescued { get; set; }

        public DateTime AuctionDate { get; set; }
    }
}
