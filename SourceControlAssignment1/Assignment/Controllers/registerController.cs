using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class registerController : Controller
    {
        // GET: register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(registermodel rm)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }

}