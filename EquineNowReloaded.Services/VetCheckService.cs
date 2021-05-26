using ElevenNoteReloaded.Data;
using EquineNowReloaded.Data;
using EquineNowReloaded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquineNowReloaded.Services
{
    public class VetCheckService
    {
        private readonly Guid _userId;

        public VetCheckService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateVetCheck(VetCheckCreate model)
        {
            var entity =
                new VetCheck()
                {
                    HorseId = model.HorseId,
                    EmployeeId = _userId,
                    ImmediateMedical = model.ImmediateMedical,
                    Injury = model.Injury,
                    IntakeNotes = model.IntakeNotes,
                    TreatmentPlan = model.TreatmentPlan,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                //var Horse = ctx.Horses.FirstOrDefault(h => h.HorseId == entity.HorseId);
                //entity.Horse = Horse;
                ctx.VetChecks.Add(entity);
                return ctx.SaveChanges() > 0; 
            }
        }

        public IEnumerable<VetCheckListItem> GetVetChecks()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .VetChecks
                    .Where(e => e.EmployeeId == _userId)
                    .Select(
                        e =>
                        new VetCheckListItem
                        {
                            VetCheckId = e.VetCheckId,
                            HorseId =e.HorseId,
                            //Name = e.Name,
                            //Breed = e.Breed,
                            //CreatedUtc = e.CreatedUtc
                        }
                      );
                return query.ToArray();
            }
        }

        public VetCheckDetail GetVetCheckById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .VetChecks
                    .SingleOrDefault(e => e.VetCheckId == id && e.EmployeeId == _userId);

                //var Horse = ctx.Horses.SingleOrDefault(h => h.HorseId == entity.HorseId);
                return      
                    new VetCheckDetail
                    {
                       HorseId = entity.HorseId,
                       VetCheckId = entity.VetCheckId,
                       Horse= ctx.Horses.Find(entity.HorseId),
                        TreatmentPlan = entity.TreatmentPlan,
                        Injury = entity.Injury,
                        IntakeNotes = entity.IntakeNotes,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateVetCheck(VetCheckEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .VetChecks
                    .Single(e => e.VetCheckId == model.VetCheckId && e.EmployeeId == _userId);

                entity.VetCheckId = model.VetCheckId;
                entity.IntakeNotes = model.IntakeNotes;
                entity.Injury = model.Injury;
                entity.TreatmentPlan = model.TreatmentPlan;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteVetCheck(int vetCheckId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .VetChecks
                    .Single(e => e.VetCheckId == vetCheckId && e.EmployeeId == _userId);

                ctx.VetChecks.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
