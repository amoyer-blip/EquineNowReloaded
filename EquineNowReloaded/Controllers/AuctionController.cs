using EquineNowReloaded.Models;
using EquineNowReloaded.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquineNowReloaded.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AuctionService(userId);
            var model = service.GetAuctions();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AuctionCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateAuctionService();

            if (service.CreateAuction(model))
            {
                TempData["SaveResult"] = "The Auction has been added.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "The Auction could not be created.");

            return View(model);
        }

        private AuctionService CreateAuctionService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AuctionService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateAuctionService();
            var model = svc.GetAuctionById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateAuctionService();
            var detail = service.GetAuctionById(id);
            var model =
                new AuctionEdit
                {
                    AuctionId = detail.AuctionId,
                    AuctionName = detail.AuctionName,
                    AuctionLocation = detail.AuctionLocation,
                    TotalHorsesRescued = detail.TotalHorsesRescued,
                    AuctionDate = detail.AuctionDate
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AuctionEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.AuctionId != id)
            {
                ModelState.AddModelError("", "The AuctionId entered does not match.");
                return View(model);
            }

            var service = CreateAuctionService();

            if (service.UpdateAuction(model))
            {
                TempData["SaveResult"] = "The auctions's information has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Unable to update.");
            return View(model);
        }


        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateAuctionService();
            var model = svc.GetAuctionById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(int id)
        {
            var service = CreateAuctionService();

            service.DeleteAuction(id);

            TempData["SaveResult"] = "Auction deleted.";

            return RedirectToAction("Index");

        }
    }
}