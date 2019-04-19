namespace betawatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CrackWatchID = c.Int(nullable: false),
                        GameTitle = c.String(maxLength: 500),
                        GameTitleSlug = c.String(maxLength: 500),
                        ReleaseDate = c.DateTime(),
                        IsAAA = c.Boolean(nullable: false),
                        LastUpdate = c.DateTime(),
                        ImageUrl = c.String(maxLength: 500),
                        SteamPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
