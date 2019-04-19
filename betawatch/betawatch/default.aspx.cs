using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using betawatch.Classes;
using betawatch.Models;

namespace betawatch
{
    public partial class _default : Page
    {
        protected static List<Games.RootObject> GamesList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Fetch a list of 50 unreleased games from crackwatch and deserialize them
            GamesList = CrackwatchFunctions.Fetch_Games();

            foreach (var game in GamesList)
            {
                TableRow gameRow = new TableRow();

                TableCell gameName = new TableCell();
                TableCell releaseDate = new TableCell();

                gameName.Text = game.title;
                releaseDate.Text = game.releaseDate.ToString("yyyy-MM-dd");

                gameRow.Cells.Add(gameName);

                gameRow.Cells.Add(releaseDate);


                GamesTable.Rows.Add(gameRow);
            }
        }

    }
}