using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Data
{
    public enum Color { Sorrel = 1, Bay, Palomino, Dun, DappleGray, Buckskin, Roan, Paint, Appaloosa, Gray, Chestnut, Black }
    public class Horse
    {
        [Key]
        public int HorseId { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public string HorseName { get; set; }

        [Required]
        [Display(Name = "Needs Urgent Care")]
        public bool ImmediateMedical { get; set; }

        [Required]
        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Required]
        [Display(Name = "Injuries")]
        public string Injury { get; set; }

        [Required]
        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        //[ForeignKey(nameof(Auction))]
        public string AuctionName { get; set; }

        [ForeignKey(nameof(Employee))]
        public int Employee { get; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
