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
        [Display(Name = "Vet Check Id")]
        public int VetCheckId { get; set; }

        [Display(Name = "Horse's Name")]
        public string Name { get; set; }
    }
}
