namespace betawatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quickfixes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "CrackWatchID", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "CrackWatchID", c => c.Int(nullable: false));
        }
    }
}
