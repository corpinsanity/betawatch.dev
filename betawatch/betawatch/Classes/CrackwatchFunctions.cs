using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using betawatch.Models;
using System.Configuration;

namespace betawatch.Classes
{
    public class CrackwatchFunctions
    {
        public static List<Games.RootObject> Fetch_Games()
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

        }
    }
}