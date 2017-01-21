namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artists", "Description", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artists", "Description", c => c.String(nullable: false, maxLength: 2000));
        }
    }
}
