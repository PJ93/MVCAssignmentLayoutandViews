using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class Contact
    {
        public static List<Contact> Contacts { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tele { get; set; }

        public Contact(string name, string email, string tele)
        {
            Name = name;
            Email = email;
            Tele = tele;
        }

    }
}