using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class Tempcheck
    {

        public static List<Tempcheck> Temapture { get; set; }
        public int msg { get; set; }
        public string scale { get; set; }

        public Tempcheck(int y)
        {
            msg = y;
        }
        

    }
}