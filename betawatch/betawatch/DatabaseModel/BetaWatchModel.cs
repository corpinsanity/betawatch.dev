using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace betawatch.DatabaseModel
{
    public partial class BetaWatchModel : DbContext
    {
        public BetaWatchModel()
            : base("name=BetaWatchModel")
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}