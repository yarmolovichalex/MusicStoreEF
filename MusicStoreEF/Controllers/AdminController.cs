using System.Collections.Generic;
using System.Web.Mvc;
using MusicStoreEF.Helpers;
using MusicStoreEF.Models;

namespace MusicStoreEF.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Admin
        public EmptyResult PopulateDb()
        {
            var artist1 = new Artist
            {
                Name = "Metallica",
                Country = "USA",
                Albums = new List<Album>
                {
                    new Album
                    {
                        Name = "Master Of Puppets",
                        Year = 1986,
                        CoverUrl = "https://lastfm-img2.akamaized.net/i/u/770x0/07f492a00c904cc6ccf868010be4d5a6.jpg",
                        Tracks = new List<Track>
                        {
                            new Track { Number = 1, Name = "Battery", Duration = DateHelper.GetSeconds(5, 13) },
                            new Track { Number = 2, Name = "Master of Puppets", Duration = DateHelper.GetSeconds(8, 35) },
                            new Track { Number = 3, Name = "The Thing That Should Not Be", Duration = DateHelper.GetSeconds(6, 36) },
                            new Track { Number = 4, Name = "Welcome Home (Sanitarium)", Duration = DateHelper.GetSeconds(6, 27) },
                            new Track { Number = 5, Name = "Disposable Heroes", Duration = DateHelper.GetSeconds(8, 17) },
                            new Track { Number = 6, Name = "Leper Messiah", Duration = DateHelper.GetSeconds(5, 40) },
                            new Track { Number = 7, Name = "Orion", Duration = DateHelper.GetSeconds(8, 27) },
                            new Track { Number = 8, Name = "Damage, Inc.", Duration = DateHelper.GetSeconds(5, 31) }
                        }
                    },
                    new Album
                    {
                        Name = "Metallica",
                        Year = 1991,
                        CoverUrl = "https://lastfm-img2.akamaized.net/i/u/770x0/42073c53961041e0b028da2f157402b6.jpg",
                        Tracks = new List<Track>
                        {
                            new Track { Number = 1, Name = "Enter Sandman", Duration = DateHelper.GetSeconds(5, 32) },
                            new Track { Number = 2, Name = "Sad but True", Duration = DateHelper.GetSeconds(5, 25) },
                            new Track { Number = 3, Name = "Holier Than Thou", Duration = DateHelper.GetSeconds(3, 48) },
                            new Track { Number = 4, Name = "The Unforgiven", Duration = DateHelper.GetSeconds(6, 27) },
                            new Track { Number = 5, Name = "Wherever I May Roam", Duration = DateHelper.GetSeconds(6, 44) },
                            new Track { Number = 6, Name = "Don't Tread on Me", Duration = DateHelper.GetSeconds(4, 0) },
                            new Track { Number = 7, Name = "Through the Never", Duration = DateHelper.GetSeconds(4, 04) },
                            new Track { Number = 8, Name = "Nothing Else Matters", Duration = DateHelper.GetSeconds(6, 29) },
                            new Track { Number = 9, Name = "Of Wolf and Man", Duration = DateHelper.GetSeconds(4, 17) },
                            new Track { Number = 10, Name = "The God That Failed", Duration = DateHelper.GetSeconds(5, 9) },
                            new Track { Number = 11, Name = "My Friend of Misery", Duration = DateHelper.GetSeconds(6, 50) },
                            new Track { Number = 12, Name = "The Struggle Within", Duration = DateHelper.GetSeconds(3, 54) }
                        }
                    }
                }
            };

            var artist2 = new Artist
            {
                Name = "Slipknot",
                Country = "USA"
            };

            var artist3 = new Artist
            {
                Name = "Rammstein",
                Country = "Germany"
            };

            //artist2.AddAlbum(new Album("Iowa", artist2, 2001, new Money(6.0m, "USD")));
            //artist2.AddAlbum(new Album("Slipknot", artist2, 1999, new Money(6.0m, "USD")));

            //artist3.AddAlbum(new Album("Mutter", artist3, 2001, new Money(8.0m, "EUR")));
            //artist3.AddAlbum(new Album("Reise, Reise", artist3, 2004, new Money(8.0m, "EUR")));

            _context.Artists.AddRange(new List<Artist> {artist1, artist2, artist3});
            _context.SaveChanges();

            return new EmptyResult();
        }

        public EmptyResult CleanDb()
        {
            _context.Artists.RemoveRange(_context.Artists);
            _context.SaveChanges();

            return new EmptyResult();
        }
    }
}