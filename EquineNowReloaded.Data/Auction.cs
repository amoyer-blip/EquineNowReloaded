using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public class Auction
    {
        [Required]
        public Guid EmployeeId { get; set; }

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
        public DateTimeOffset AuctionDate { get; set; }

        //[ForeignKey(nameof(Horse))]
        //public int? HorseId { get; set; }
        //public virtual Horse Horse { get; set; }

        public virtual List<Horse> Horses { get; set; } = new List<Horse>();

    }
}
