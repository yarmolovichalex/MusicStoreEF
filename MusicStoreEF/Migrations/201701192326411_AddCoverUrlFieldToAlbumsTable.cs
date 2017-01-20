namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoverUrlFieldToAlbumsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "CoverUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "CoverUrl");
        }
    }
}
