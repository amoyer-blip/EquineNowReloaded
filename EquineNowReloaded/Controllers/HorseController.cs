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
        // GET: Note
        //Displays all horses for the current user 
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new HorseService(userId);
            var model = service.GetHorses();
            //var model = new HorseListItem[0];

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
    }
}