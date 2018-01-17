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
        public ActionResult People(string Addpeople)
        {
            //PeopleM.Peoples = new List<PeopleM>();
            
            if (Addpeople != null)
            {
                PeopleM.Peoples.Add(new PeopleM(Addpeople));
            }

            return View();
        }

        // POST: User
        //[HttpPost]
        //public ActionResult People(string Search)
        //{

        //}


    }
}