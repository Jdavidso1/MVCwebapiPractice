using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwebapi.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}