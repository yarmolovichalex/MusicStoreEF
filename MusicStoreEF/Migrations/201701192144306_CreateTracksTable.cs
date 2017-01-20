namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTracksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums");
            DropIndex("dbo.Tracks", new[] { "AlbumId" });
            DropTable("dbo.Tracks");
        }
    }
}
