﻿using ElevenNoteReloaded.Data;
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
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        }

    }
}