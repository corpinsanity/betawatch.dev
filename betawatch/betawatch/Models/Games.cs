using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace betawatch.Models
{
    public class Games
    {
        public class RootObject
        {
            public string _id { get; set; }
            public bool isAAA { get; set; }
            public int NFOsCount { get; set; }
            public int commentsCount { get; set; }
            public int followersCount { get; set; }
            public List<string> protections { get; set; }
            public List<object> versions { get; set; }
            public List<object> groups { get; set; }
            public DateTime updatedAt { get; set; }
            public string title { get; set; }
            public string slug { get; set; }
            public DateTime releaseDate { get; set; }
            public string image { get; set; }
            public string imagePoster { get; set; }
            public double steamPrice { get; set; }
            public string url { get; set; }
        }
    }
}