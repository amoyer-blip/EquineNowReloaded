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
    public class HorseService
    {
        private readonly Guid _userId;

        public HorseService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateHorse(HorseCreate model)
        {
            var entity =
                new Horse()
                {
                    EmployeeId = _userId,
                    HorseName = model.HorseName,
                    ImmediateMedical = model.ImmediateMedical,
                    IntakeNotes = model.IntakeNotes,
                    Injury = model.Injury,
                    Color = model.Color,
                    AuctionName = model.AuctionName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Horses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // See all horses by employee 
        public IEnumerable<HorseListItem> GetHorses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Horses
                    .Where(e => e.EmployeeId == _userId)
                    .Select(
                        e =>
                        new HorseListItem
                        {
                            HorseId = e.HorseId,
                            HorseName = e.HorseName,
                            Color = e.Color,
                            IntakeNotes = e.IntakeNotes,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        }
        public HorseDetail GetHorseById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Horses
                    .Single(e => e.HorseId == id && e.EmployeeId == _userId);
                return
                    new HorseDetail
                    {
                        HorseId = entity.HorseId,
                        HorseName = entity.HorseName,
                        ImmediateMedical = entity.ImmediateMedical,
                        IntakeNotes = entity.IntakeNotes,
                        Injury = entity.Injury,
                        Color = entity.Color,
                        AuctionName = entity.AuctionName,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateHorse(HorseEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Horses
                    .Single(e => e.HorseId == model.HorseId && e.EmployeeId == _userId);

                entity.HorseId = model.HorseId;
                entity.HorseName = model.HorseName;
                entity.ImmediateMedical = model.ImmediateMedical;
                entity.IntakeNotes = model.IntakeNotes;
                entity.Injury = model.Injury;
                entity.Color = model.Color;
                entity.AuctionName = model.AuctionName;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteHorse(int horseId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Horses
                    .Single(e => e.HorseId == horseId && e.EmployeeId == _userId);

                ctx.Horses.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
