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
        [Display(Name = "Horse Id")]
        public int HorseId { get; set; }

        [Display(Name = "Horse's Name")]
        public string Name { get; set; }

        [Display(Name = "Treatment Plan")]
        public string TreatmentPlan { get; set; }
    }
}
