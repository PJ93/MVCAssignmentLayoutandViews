using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class Projectlist
    {
        public static List<Projectlist> Projectlistings { get; set; }
        public string PName { get; set; }
        public string GitLink { get; set; }

        public Projectlist (string pname, string gitlink)
        {
            PName = pname;
            GitLink = gitlink;
        }


    }
}