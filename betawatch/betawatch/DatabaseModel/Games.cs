using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace betawatch.DatabaseModel
{
    public class Games
    {
        [Key]
        public int Id { get; set; }

        public int CrackWatchID { get; set; }

        [MaxLength(500)]
        public string GameTitle { get; set; }

        [MaxLength(500)]
        public string GameTitleSlug { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public bool IsAAA { get; set; }

        public List<string> Protections { get; set; }

        public DateTime? LastUpdate { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public double SteamPrice { get; set; }
    }
}