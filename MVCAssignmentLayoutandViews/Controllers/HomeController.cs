using MVCAssignmentLayoutandViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignmentLayoutandViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }

        // GET: Projects
        public ActionResult Projects()
        {
            Projectlist.Projectlistings = new List<Projectlist>();
            Projectlist.Projectlistings.Add(new Projectlist("First stand alone code", "https://github.com/PJ93/First-proper-standalone-code"));
            Projectlist.Projectlistings.Add(new Projectlist("Basic Calculator", "https://github.com/PJ93/Basic-calculator"));
            Projectlist.Projectlistings.Add(new Projectlist("Text based Golf Game", "https://github.com/PJ93/Golf-Assignment-Lexicon"));
            Projectlist.Projectlistings.Add(new Projectlist("Text based Arena Fighter", "https://github.com/PJ93/Arena-Fighter-PJ"));
            Projectlist.Projectlistings.Add(new Projectlist("Vending Machine", "https://github.com/PJ93/VendingMachinePJ"));
            return View();
        }

        public ActionResult Contacts()
        {
            Contact.Contacts = new List<Contact>();
            Contact.Contacts.Add(new Contact("Patrik","PJ93coder@gmail.com","0702994326"));

            return View();
        }

    }
}