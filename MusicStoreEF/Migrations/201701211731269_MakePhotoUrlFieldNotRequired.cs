namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakePhotoUrlFieldNotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artists", "PhotoUrl", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artists", "PhotoUrl", c => c.String(nullable: false, maxLength: 2000));
        }
    }
}
