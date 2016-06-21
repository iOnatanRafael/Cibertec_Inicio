using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()            
        {
            var client = new Client()
            {
                ID = 1,
                LastName = "Cueva",
                Name = "Aladino"
            };
            return View(client);
        }
    }
}