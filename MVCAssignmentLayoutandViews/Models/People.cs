using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class PeopleM
    {
        static int id = 0;
        private int ID { get; set; }
        public static List<PeopleM> Peoples {get;set;}
        public string Name { get; set; }

        static PeopleM()
        {
            Peoples = new List<PeopleM>();
        }

        private PeopleM()
        {
            ID = id++;
        }

        public PeopleM (string name)
        {
            Name = name;
        } 
    }
}