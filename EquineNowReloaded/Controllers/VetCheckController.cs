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
    public class VetCheckController : Controller
    {
        // GET: VetCheck
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new VetCheckService(userId);
            var model = service.GetVetChecks();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VetCheckCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateVetCheckService();

            if (service.CreateVetCheck(model))
            {
                TempData["SaveResult"] = "The VetCheck has been added.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "The VetCheck could not be created.");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateVetCheckService();
            var model = svc.GetVetCheckById(id);

            return View(model);
        }

        private VetCheckService CreateVetCheckService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new VetCheckService(userId);
            return service;
        }
    }
}