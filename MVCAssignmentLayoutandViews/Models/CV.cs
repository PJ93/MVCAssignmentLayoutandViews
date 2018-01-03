using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{

    public class Job
    {
        public static List<Job> Jobs { get; set; }
        public string JName { get; set; }
        public string JLocation { get; set; }
        public string JYears { get; set; }

        public Job(string jname, string jlocation, string jyears)
        {
            JName = jname;
            JLocation = jlocation;
            JYears = jyears;
        }

    }

    public class Education
    {
        public static List<Education> Edu { get; set; }
        public string EName { get; set; }
        public string ELocation { get; set; }
        public string EYears { get; set; }

        public Education(string ename, string eyears)
        {
            EName = ename;
            EYears = eyears;
        }

    }
}