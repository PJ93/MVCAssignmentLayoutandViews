﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class PeopleM
    {

        public static List<PeopleM> Peoples {get;set;}
        public string Name { get; set; }

        static PeopleM()
        {
            Peoples = new List<PeopleM>();
        }

        private ID()
        {

        }

        public PeopleM (string name)
        {
            Name = name;
        } 
    }
}