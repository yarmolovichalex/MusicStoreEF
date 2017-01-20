namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberFieldToTracksTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "Number");
        }
    }
}
