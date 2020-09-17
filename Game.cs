using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        Score score = new Score();

        public void GameLogic()
        {
            while (score.Player1Score < 300 && score.Player2Score < 300)
            {
                for (int i = 0; i < 3; i++)
                {
                    score.Player1Score += score.score();
                    score.Player2Score += score.score();
                }
            }
        }

        public string DetermineWinner()
        {
            if (score.Player1Score > score.Player2Score)
                return string.Format("Player 1: {0} <p>Player 2 {1}" +
                    "<p>The Winner is Player 1", score.Player1Score, score.Player2Score);

            else if (score.Player2Score > score.Player1Score)
                return string.Format("Player 1: {0} <p>Player 2 {1}" +
                    " <p>The Winner is Player 2", score.Player1Score, score.Player2Score);

            else return string.Format("Player 1: {0} <p>Player 2 {1}" +
                " <p>Draw", score.Player1Score, score.Player2Score);
        }
    }
}