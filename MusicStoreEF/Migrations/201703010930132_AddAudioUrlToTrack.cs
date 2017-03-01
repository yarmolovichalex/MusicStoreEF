namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAudioUrlToTrack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tracks", "AudioUrl", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tracks", "AudioUrl");
        }
    }
}
