using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Models
{
   public class VetCheckEdit
    {
        public int VetCheckId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public string Sex { get; set; }

        public string Breed { get; set; }

        public string TreatmentPlan { get; set; }
    }
}
