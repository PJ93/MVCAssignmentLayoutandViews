using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignmentLayoutandViews.Models
{
    public class Guessing_game
    {
        public int guess { get; set; }
        public string result = "";
        public int random { get; set; }
        public Guessing_game(int guess)
        {

            Random rnd = new Random();
            int random = rnd.Next(1, 100);
            bool keepalive = true;
            while (keepalive)
            {
                

                if (this.guess == random)
                {
                    this.guess = guess;
                    result = "Welldone";
                    //keepalive = false;
                }
                else
                {
                    result = "nein";
                }

            }

        }

    }
}//namespace