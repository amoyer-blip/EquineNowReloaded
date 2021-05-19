using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class HorseListItem
    {
        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Horse's Name")]
        public string HorseName { get; set; }

        [Display(Name = "Color and Markings")]
        public string Color { get; set; }

        [Display(Name = "Notes")]
        public string IntakeNotes { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
