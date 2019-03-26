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


        }

    }
}