namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Country", c => c.String());
            AddColumn("dbo.Albums", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.Tracks", "Duration", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Duration");
            DropColumn("dbo.Albums", "Year");
            DropColumn("dbo.Artists", "Country");
        }
    }
}
