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
                    HorseId = (model.HorseId is null) ? null : model.HorseId,
                    EmployeeId = _userId,
                    Age = model.Age,
                    Height = model.Height,
                    Weight = model.Weight,
                    Sex = model.Sex,
                    Breed = model.Breed,
                    TreatmentPlan = model.TreatmentPlan,
                    Name = model.Name,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.VetChecks.Add(entity);
                return ctx.SaveChanges() == 1; 
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
                            //HorseId = e.HorseId,
                            Name = e.Name,
                            Breed = e.Breed,
                            CreatedUtc = e.CreatedUtc
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
                    .SingleOrDefault(e => e.HorseId == id && e.EmployeeId == _userId);
                return
                    new VetCheckDetail
                    {
                        HorseId = (entity.HorseId is null) ? null : entity.HorseId,
                        //EmployeeId = entity.EmployeeId,
                        Name = entity.Name,
                        Age = entity.Age,
                        Height = entity.Height,
                        Weight = entity.Weight,
                        Sex = entity.Sex,
                        Breed = entity.Breed,
                        TreatmentPlan = entity.TreatmentPlan,
                        CreatedUtc = entity.CreatedUtc
                    };
            }
        }
    }
}
