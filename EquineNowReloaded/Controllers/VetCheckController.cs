using EquineNowReloaded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquineNowReloaded.Controllers
{
    public class VetCheckController : Controller
    {
        // GET: VetCheck
        public ActionResult Index()
        {
            //var userId = Guid.Parse(User.Identity.GetUserId());
            //var service = new VetCheckService(userId);
            //var model = service.GetHorses();

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(VetCheckCreate model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    //var service = CreateVetCheckService();

        //    if (service.CreateVetCheck(model))
        //    {
        //        TempData["SaveResult"] = "The note has been added.";
        //        return RedirectToAction("Index");
        //    };

        //    ModelState.AddModelError("", "Note could not be created.");

        //    return View(model);
        //}
    }
}