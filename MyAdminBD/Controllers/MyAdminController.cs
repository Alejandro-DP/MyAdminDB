using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAdminBD.Controllers
{
    public class MyAdminController : Controller
    {
        // GET: MyAdmin
        public ActionResult ViewLog()
        {
            return View();
        }
    }
}