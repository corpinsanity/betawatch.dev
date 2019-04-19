using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using betawatch.Models;
using Hangfire;
using System.Configuration;
using betawatch.DatabaseModel;
using System.Threading;

namespace betawatch.Classes
{
    public class CrackwatchFunctions
    {
        public static List<Games.RootObject> Fetch_Games(int page)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["CrackWatchAPI"] + "sort_by=release_date&is_sort_inverted=true&is_released=false&page=0");
            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string plainJson;
            using (var sr = new StreamReader(response.GetResponseStream()))
                plainJson = sr.ReadToEnd();

            return JsonConvert.DeserializeObject<List<Games.RootObject>>(plainJson);
        }

        public static void RefreshDatabase()
        {
            List<Game> GamesList = new List<Game>();

            bool cont = false;
            int nxtPage = 0;

            do
            {
                foreach (var game in Fetch_Games(nxtPage))
                {
                    var gem = new Game
                    {
                        GameTitle = game.title,
                        GameTitleSlug = game.slug,
                        CrackWatchID = game._id,
                        ImageUrl = game.image,
                        IsAAA = game.isAAA,
                        ReleaseDate = game.releaseDate,
                        LastUpdate = game.updatedAt,
                        SteamPrice = game.steamPrice
                    };
                    GamesList.Add(gem);
                    cont = true;
                }
                nxtPage++;

                ///Crackwatch API only allows 1 call/second
                Thread.Sleep(2000);
            } while (cont);

        }
    }
}