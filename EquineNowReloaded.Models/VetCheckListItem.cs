using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
    public class VetCheckListItem
    {
        [Display(Name = "VetCheck Id")]
        public int VetCheckId { get; set; }

        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Breed")]
        public string Breed { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
