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
                    Age = model.Age,
                    Breed = model.Breed,
                    Height = model.Height,
                    Weight = model.Weight,
                    Sex = model.Sex,
                    Color = model.Color,
                    AuctionId = model.AuctionId,
                    //Notes = model.Notes,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Horses.Add(entity);
                if (entity.AuctionId != null)
                {
                    var auction = ctx.Auctions.SingleOrDefault(a => a.AuctionId == entity.AuctionId);
                    auction.Horses.Add(entity);
                }
                return ctx.SaveChanges() == 1;
            }
        }


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
                            Color = e.Color
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
                        Age = entity.Age,
                        Color = entity.Color,
                        Height= entity.Height,
                        Weight=entity.Weight,
                        Sex=entity.Sex,
                        Breed=entity.Breed,
                        AuctionId = (entity.AuctionId is null) ? null : entity.AuctionId,
                        AuctionName = ctx.Auctions.FirstOrDefault(a => a.AuctionId == entity.AuctionId).AuctionName,
                        CreatedUtc = entity.CreatedUtc
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
                entity.Age = model.Age;
                entity.Height = model.Height;
                entity.Weight = model.Weight;
                entity.Sex = model.Sex;
                entity.Breed = model.Breed;
                entity.Color = model.Color;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteHorse(int horseId)
        {
            using (var ctx = new ApplicationDbContext())
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
