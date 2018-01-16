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
        public ActionResult FeverCheck(string msg, string scale)
        {
            int calc = Convert.ToInt32(msg);
            string awnser = " ";

            if(calc > 50)
            {
                awnser = "I'm pretty sure you're dead.";
            }
            else if (calc == 37 || calc == 36)
            {
                awnser = "you're perfectly fine";
            }
            else if (calc == 38)
            {
                awnser = "you got a fever there";
            }
            else if (calc > 40)
            {
                awnser = "Now thats one hell of a fever";
            }
            else if (calc < 36)
            {
                awnser = "You got hypothermia, go seek a doctor";
            }





            ViewBag.awnser = awnser;
            return View();
        }

        //GET: Guessingame
        [HttpGet]
        public ActionResult Guessingame()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            Session["Random"] = random;

            return View();
        }

        //POST: Guessingame
        [HttpPost]
        public ActionResult Guessingame(int guess)
        {
            int tries = 1 + 1;
            ViewBag.result = "";
            string result;
            string amountoftries;
            HttpCookie Highscore = Request.Cookies["highscore"];

            if (Highscore == null)
            {
                Highscore = new HttpCookie("high");

            }
            else
            {
                tries++;
                amountoftries = tries.ToString();
                Highscore["highscore"] = amountoftries;

            }


            if (guess == (int)Session["Random"])
            {
                result = "Correct!";
                //tries++;
                amountoftries = tries.ToString();
                Highscore["highscore"] = amountoftries;

            }
            else if (guess < (int)Session["Random"]) 
            {
                result = "Too low";
                //tries++;
            }
            else if (guess > (int)Session["Random"])
            {
                result = "Too high";
                //tries++;
            }
            else
            {
                result = "no";
                
            }
            ViewBag.result = result;
            ViewBag.F = Highscore["highscore"];

            return View();
        }

    }
}