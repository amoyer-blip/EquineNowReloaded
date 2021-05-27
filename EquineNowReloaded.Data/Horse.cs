using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public class Horse
    {
        [Key]
        public int HorseId { get; set; }

        public virtual List<VetCheck> VetChecks { get; set; } = new List<VetCheck>();

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public string HorseName { get; set; }
      
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [Required]
        [Display(Name = "Weight")]
        public decimal Weight { get; set; }

        [Required]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Required]
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Required]
        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        public string AuctionName { get; set; }

        [ForeignKey(nameof(Auction))]
        public int? AuctionId { get; set; }

        public virtual Auction Auction { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
