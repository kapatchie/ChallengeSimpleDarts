using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }

        public Score()
        {
            Player1Score = 0;
            Player2Score = 0;
        }
        public int score()
        {
            Darts dart = new Darts();

            int throwValue = dart.Throw();
            if (throwValue != 0)
            {
                if (dart.isMultiplyer()) return throwValue *= 2;
                if (dart.isMultiplyer()) return throwValue *= 3;
            }

            else if (throwValue == 0)
            {
                throwValue = dart.bull();
                if (throwValue == 1) return 50;
                else return 25;
            }


            return throwValue;
        }
    }
}