using EquineNowReloaded.Models;
using EquineNowReloaded.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;

namespace EquineNowReloaded.Controllers
{
    [Authorize]
    public class HorseController : Controller
    {
        // GET: Horse
        
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HorseService(userId);
            var model = service.GetHorses();
          
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HorseCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateHorseService();

            if (service.CreateHorse(model))
            {
                TempData["SaveResult"] = "The horse has been added.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Horse could not be created.");

            return View(model);
        }

        private HorseService CreateHorseService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HorseService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateHorseService();
            var model = svc.GetHorseById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateHorseService();
            var detail = service.GetHorseById(id);
            var model =
                new HorseEdit
                {
                    HorseId = detail.HorseId,
                    HorseName = detail.HorseName,
                    ImmediateMedical = detail.ImmediateMedical,
                    IntakeNotes = detail.IntakeNotes,
                    Injury = detail.Injury,
                    Color = detail.Color,
                    //AuctionName = detail.AuctionName
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HorseEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.HorseId != id)
            {
                ModelState.AddModelError("", "The HorseId entered does not match.");
                return View(model);
            }

            var service = CreateHorseService();

            if (service.UpdateHorse(model))
            {
                TempData["SaveResult"] = "The horse's information has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Unable to update.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateHorseService();
            var model = svc.GetHorseById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteItem(int id)
        {
            var service = CreateHorseService();

            service.DeleteHorse(id);

            TempData["SaveResult"] = "Horse deleted.";

            return RedirectToAction("Index");

        }
    }
}