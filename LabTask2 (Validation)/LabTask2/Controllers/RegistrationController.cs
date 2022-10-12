using LabTask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Profile(Student student)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            //

            return View(student);
        }
    }
}