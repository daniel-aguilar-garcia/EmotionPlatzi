using EmotionPlatzi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmotionPlatzi.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var modelo = new Home();
            modelo.WelcomeMessage = "Bienvenido a la web";
            return View(modelo);
        }

        public ActionResult IndexAlt()
        {
            var modelo = new Home();
            modelo.WelcomeMessage = "Bienvenido a la web";

            return View(modelo);
        }
    }
}