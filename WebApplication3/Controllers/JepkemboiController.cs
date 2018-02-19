using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class JepkemboiController : Controller
    {
        // GET: Jepkemboi
        [Route("Jepkemboi")]
        [Route("Jepkemboi/Index")]
        public ActionResult Index()
        {
            ViewData["message"] = "Index.cshtml";
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
    }
}