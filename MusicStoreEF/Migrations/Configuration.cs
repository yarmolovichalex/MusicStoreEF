using MusicStoreEF.Models;

namespace MusicStoreEF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MusicStoreEF.Models.DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MusicStoreEF.Models.DbContext context)
        {
            context.Genres.AddOrUpdate(new Genre
            {
                Id = 1, Name = "Tech House"
            },
            new Genre
            {
                Id = 2, Name = "Techno"
            });
        }
    }
}
