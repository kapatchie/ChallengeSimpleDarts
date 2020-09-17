using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
    
    public partial class Default : System.Web.UI.Page
    {
        protected void okButton_Click(object sender, EventArgs e)
        {
            DisplayResults();
        }
        public void DisplayResults()
        {
            Game game = new Game();
            game.GameLogic();
            resultLabel.Text = game.DetermineWinner();
        }

    }

}



