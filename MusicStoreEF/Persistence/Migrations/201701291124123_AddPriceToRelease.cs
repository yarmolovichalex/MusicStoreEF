namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriceToRelease : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Releases", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Releases", "Price");
        }
    }
}
