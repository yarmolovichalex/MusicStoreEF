namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNamesRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("[dbo].[Artists]", "Name", c => c.String(nullable: false));
            AlterColumn("[dbo].[Albums]", "Name", c => c.String(nullable: false));
            AlterColumn("[dbo].[Tracks]", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("[dbo].[Artists]", "Name", c => c.String());
            AlterColumn("[dbo].[Albums]", "Name", c => c.String());
            AlterColumn("[dbo].[Tracks]", "Name", c => c.String());
        }
    }
}
