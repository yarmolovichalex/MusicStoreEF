namespace MusicStoreEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreToField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Releases", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Tracks", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Releases", "GenreId");
            CreateIndex("dbo.Tracks", "GenreId");
            AddForeignKey("dbo.Releases", "GenreId", "dbo.Genres", "Id");
            AddForeignKey("dbo.Tracks", "GenreId", "dbo.Genres", "Id");
            DropColumn("dbo.Releases", "Genre");
            DropColumn("dbo.Tracks", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tracks", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Releases", "Genre", c => c.String(nullable: false));
            DropForeignKey("dbo.Tracks", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Releases", "GenreId", "dbo.Genres");
            DropIndex("dbo.Tracks", new[] { "GenreId" });
            DropIndex("dbo.Releases", new[] { "GenreId" });
            DropColumn("dbo.Tracks", "GenreId");
            DropColumn("dbo.Releases", "GenreId");
        }
    }
}
