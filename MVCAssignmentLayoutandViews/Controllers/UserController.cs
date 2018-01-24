using MVCAssignmentLayoutandViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignmentLayoutandViews.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult People()
        {
            
            return View();
        }

        // POST: User
        [HttpPost]
        public ActionResult PeopleAdd(string Addpeople)
        {
            //PeopleM.Peoples = new List<PeopleM>();
            
            if (Addpeople != null)
            {
                PeopleM.Peoples.Add(new PeopleM(Addpeople));
            }

            return View("People");
        }

        //POST: User
        [HttpPost]
        public ActionResult PeopleSearch(string Search)
        {



            return View("People");
        }

        [HttpGet]
        public ActionResult PeopleEdit(int id)
        {
            


            return View("PeopleM");
        }

        public ActionResult AjaxDeletePeople(int id)
        {

            PeopleM.Peoples.Remove(PeopleM.Peoples.SingleOrDefault(p => p.ID == id));

            return View("People");
        }


    }
}