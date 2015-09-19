using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JailBreaker.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Math()
        {
            return View();
        }

        public ActionResult Science()
        {
            return View();
        }

        public ActionResult Technology()
        {
            return View();
        }
    }
}