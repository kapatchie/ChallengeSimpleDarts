using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{

    public class Darts
    {
        static Random random = new Random();

        public int Throw()
        {
            return random.Next(0, 21);
        }

        public bool isMultiplyer()
        {
            int Value = random.Next(1, 6);
            if (Value == 1) return true;
            else return false;
        }

        public int bull()
        {
            return random.Next(1, 6);
        }
    }

}