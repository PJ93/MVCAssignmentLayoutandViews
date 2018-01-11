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
        int thenumber;

        // GET: Home
        public ActionResult Index()
        {
            return View();
            
        }

        // GET: About
        public ActionResult About()
        {
            Job.Jobs = new List<Job>();
            Job.Jobs.Add(new Job("NIBE AB", "Markaryd" ,"Summer 2015 - Spring 2017"));
            Job.Jobs.Add(new Job("Telecare", "Ljungby" , "Winter 2013 - Summer 2014"));
            ///////////////////////>
            Education.Edu = new List<Education>();
            Education.Edu.Add(new Education("Lexicon", "Växjö", "C#, .Net", "2017 - present"));
            Education.Edu.Add(new Education("Jönköping University", "Jönköping", "Inbyggda system", "2013 [Did not finish education]"));
            Education.Edu.Add(new Education("Sunnebo Skolan", "Ljungby", "Komvux", "2012 winter"));
            Education.Edu.Add(new Education("Sunnebo Skolan","Ljungby","Teknik Programmet","2009 - 2012"));
            Education.Edu.Add(new Education("Åbyskolan", "Lagan", "Grundskola", "2000 - 2009"));

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
            Contact.Contacts.Add(new Contact("Patrik Jörgensen","PJ93coder@gmail.com","0702994326"));

            return View();
        }

        //GET: FeverCheck
        public ActionResult FeverCheck()
        {
            return View();
        }

        //POST: FeverCheck
        [HttpPost]
        public ActionResult FeverCheck(int msg, string scale, bool Check)
        {
            ViewBag.msg = msg;
            return View();
        }

        //GET: Guessingame
        [HttpGet]
        public ActionResult Guessingame()
        {
            Random rnd = new Random();
            thenumber = 4;

            return View();
        }

        //POST: Guessingame
        [HttpPost]
        public ActionResult Guessingame(int guess)
        {
            string result;
            if (guess == thenumber)
            {
                result = "yes";
                ViewBag.result = result;
            }
            else
            {
                result = "no";
                ViewBag.result = result;
            }
            
            return View();
        }

    }
}