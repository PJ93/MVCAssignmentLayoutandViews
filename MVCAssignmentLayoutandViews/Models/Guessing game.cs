using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class Guessing_game
    {
        public int msg { get; set; }
        public string result = "";
        public Guessing_game(int msg)
        {

            Random rnd = new Random();
            bool keepalive = true;
            while (keepalive)
            {
                int random = rnd.Next(1, 100);

                if (msg == random)
                {
                    result = "Welldone";
                    keepalive = false;
                }
                else
                {
                    result = "nein";
                }

            }

        }

    }
}//namespace