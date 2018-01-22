using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class PeopleM
    {
        static int id = 0;
        public int ID { get; set; }
        public static List<PeopleM> Peoples {get;set;}
        public string Name { get; set; }

        static PeopleM()
        {
            Peoples = new List<PeopleM>();
        }

        public PeopleM (string name)
        {

            Name = name;
            ID = id++;
        } 
    }
}