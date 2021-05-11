using EquineNowReloaded.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquineNowReloaded.Controllers
{
    [Authorize]
    public class HorseController : Controller
    {
        // GET: Note
        //Displays all the notes for the current use
        public ActionResult Index()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            //var service = new HorseService(userId);
            //var model = service.GetHorses();

            var model = new HorseListItem[0];

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
                //return View(model);
            }
            return View(model);

            //var userId = Guid.Parse(User.Identity.GetUserId());
            //var service = new HorseService(userId);

            //service.CreateHorse(model);

            //return RedirectToAction("Index");
        }
    }
}