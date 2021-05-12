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
    public class AuctionService
    {
        private readonly Guid _userId;

        public AuctionService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateAuction(AuctionCreate model)
        {
            var entity =
                new Auction()
                {
                    EmployeeId = _userId,
                    AuctionName = model.AuctionName,
                    AuctionLocation = model.AuctionLocation,
                    TotalHorsesRescued = model.TotalHorsesRescued,
                    AuctionDate = model.AuctionDate
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Auctions.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<AuctionListItem> GetAuctions()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Auctions
                    .Where(e => e.EmployeeId == _userId)
                    .Select(
                        e =>
                        new AuctionListItem
                        {
                            AuctionId = e.AuctionId,
                            AuctionName = e.AuctionName,
                            AuctionLocation = e.AuctionLocation,
                            AuctionDate = e.AuctionDate,
                            TotalHorsesRescued = e.TotalHorsesRescued
                        }
                        );
                return query.ToArray();
            }
        }

        public AuctionDetail GetAuctionById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Auctions
                    .Single(e => e.AuctionId == id && e.EmployeeId == _userId);
                return
                    new AuctionDetail
                    {
                       AuctionId = entity.AuctionId,
                       AuctionName = entity.AuctionName,
                       AuctionLocation = entity.AuctionLocation,
                       AuctionDate = entity.AuctionDate,
                       TotalHorsesRescued = entity.TotalHorsesRescued
                    };
            }
        }

        public bool UpdateAuction(AuctionEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Auctions
                    .Single(e => e.AuctionId == model.AuctionId && e.EmployeeId == _userId);

                entity.AuctionId = model.AuctionId;
                entity.AuctionName = model.AuctionName;
                entity.AuctionLocation = model.AuctionLocation;
                entity.AuctionDate = model.AuctionDate;
                entity.TotalHorsesRescued = model.TotalHorsesRescued;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteAuction(int auctionId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Auctions
                    .Single(e => e.AuctionId == auctionId && e.EmployeeId == _userId);

                ctx.Auctions.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
