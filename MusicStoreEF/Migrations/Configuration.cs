using MusicStoreEF.Core.Models;
using MusicStoreEF.Persistence;

namespace MusicStoreEF.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbContext context)
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
