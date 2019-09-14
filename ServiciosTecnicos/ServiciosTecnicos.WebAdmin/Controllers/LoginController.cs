using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTecnicos.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(); //Este no hara nada
        }
        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            return RedirectToAction("Index","Home");
        }
    }
}