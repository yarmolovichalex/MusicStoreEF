using MusicStoreEF.Helpers;
using MusicStoreEF.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MusicStoreEF.Controllers
{
    public class AdminController : Controller
    {
        private readonly MusicStoreDbContext _context;

        public AdminController()
        {
            _context = new MusicStoreDbContext();
        }

        // GET: Admin
        //public EmptyResult PopulateDb()
        //{
        //    var artist1 = new Artist
        //    {
        //        Name = "Metallica",
        //        Country = "USA",
        //        Albums = new List<Album>
        //        {
        //            new Album
        //            {
        //                Name = "Master Of Puppets",
        //                Year = 1986,
        //                CoverUrl = "https://lastfm-img2.akamaized.net/i/u/770x0/07f492a00c904cc6ccf868010be4d5a6.jpg",
        //                Tracks = new List<Track>
        //                {
        //                    new Track { Number = 1, Name = "Battery", Duration = DateHelper.GetSeconds(5, 13) },
        //                    new Track { Number = 2, Name = "Master of Puppets", Duration = DateHelper.GetSeconds(8, 35) },
        //                    new Track { Number = 3, Name = "The Thing That Should Not Be", Duration = DateHelper.GetSeconds(6, 36) },
        //                    new Track { Number = 4, Name = "Welcome Home (Sanitarium)", Duration = DateHelper.GetSeconds(6, 27) },
        //                    new Track { Number = 5, Name = "Disposable Heroes", Duration = DateHelper.GetSeconds(8, 17) },
        //                    new Track { Number = 6, Name = "Leper Messiah", Duration = DateHelper.GetSeconds(5, 40) },
        //                    new Track { Number = 7, Name = "Orion", Duration = DateHelper.GetSeconds(8, 27) },
        //                    new Track { Number = 8, Name = "Damage, Inc.", Duration = DateHelper.GetSeconds(5, 31) }
        //                }
        //            },
        //            new Album
        //            {
        //                Name = "Metallica",
        //                Year = 1991,
        //                CoverUrl = "https://lastfm-img2.akamaized.net/i/u/770x0/42073c53961041e0b028da2f157402b6.jpg",
        //                Tracks = new List<Track>
        //                {
        //                    new Track { Number = 1, Name = "Enter Sandman", Duration = DateHelper.GetSeconds(5, 32) },
        //                    new Track { Number = 2, Name = "Sad but True", Duration = DateHelper.GetSeconds(5, 25) },
        //                    new Track { Number = 3, Name = "Holier Than Thou", Duration = DateHelper.GetSeconds(3, 48) },
        //                    new Track { Number = 4, Name = "The Unforgiven", Duration = DateHelper.GetSeconds(6, 27) },
        //                    new Track { Number = 5, Name = "Wherever I May Roam", Duration = DateHelper.GetSeconds(6, 44) },
        //                    new Track { Number = 6, Name = "Don't Tread on Me", Duration = DateHelper.GetSeconds(4, 0) },
        //                    new Track { Number = 7, Name = "Through the Never", Duration = DateHelper.GetSeconds(4, 04) },
        //                    new Track { Number = 8, Name = "Nothing Else Matters", Duration = DateHelper.GetSeconds(6, 29) },
        //                    new Track { Number = 9, Name = "Of Wolf and Man", Duration = DateHelper.GetSeconds(4, 17) },
        //                    new Track { Number = 10, Name = "The God That Failed", Duration = DateHelper.GetSeconds(5, 9) },
        //                    new Track { Number = 11, Name = "My Friend of Misery", Duration = DateHelper.GetSeconds(6, 50) },
        //                    new Track { Number = 12, Name = "The Struggle Within", Duration = DateHelper.GetSeconds(3, 54) }
        //                }
        //            }
        //        }
        //    };

        //    var artist2 = new Artist
        //    {
        //        Name = "Slipknot",
        //        Country = "USA"
        //    };

        //    var artist3 = new Artist
        //    {
        //        Name = "Rammstein",
        //        Country = "Germany"
        //    };

        //    //artist2.AddAlbum(new Album("Iowa", artist2, 2001, new Money(6.0m, "USD")));
        //    //artist2.AddAlbum(new Album("Slipknot", artist2, 1999, new Money(6.0m, "USD")));

        //    //artist3.AddAlbum(new Album("Mutter", artist3, 2001, new Money(8.0m, "EUR")));
        //    //artist3.AddAlbum(new Album("Reise, Reise", artist3, 2004, new Money(8.0m, "EUR")));

        //    _context.Artists.AddRange(new List<Artist> {artist1, artist2, artist3});
        //    _context.SaveChanges();

        //    return new EmptyResult();
        //}

        public EmptyResult PopulateDb()
        {
            var greenVelvet = new Artist {Name = "Green Velvet", PhotoUrl = "https://geo-media.beatport.com/image/6303411.jpg"};
            var prokAndFitch = new Artist {Name = "Prok & Fitch", PhotoUrl = "https://geo-media.beatport.com/image/11443832.jpg"};
            var detlef = new Artist {Name = "Detlef", PhotoUrl = "https://geo-media.beatport.com/image/11181807.jpg" };
            var osseyJames = new Artist {Name = "Ossey James" };
            var cubicolor = new Artist {Name = "Cubicolor" };
            var patriceBaumel = new Artist {Name = "Patrice Baumel", PhotoUrl = "https://geo-media.beatport.com/image/9156146.jpg" };
            var pigAndDan = new Artist {Name = "Pig&Dan", PhotoUrl = "https://geo-media.beatport.com/image/12352027.jpg" };
            var dennisCruz = new Artist {Name = "Dennis Cruz", PhotoUrl = "https://geo-media.beatport.com/image/12585001.jpg" };

            var relief = new Label {Name = "Relief", CoverUrl = "https://geo-media.beatport.com/image/11354940.jpg"};
            var repopulateMars = new Label {Name = "Repopulate Mars", CoverUrl = "https://geo-media.beatport.com/image/13003011.jpg" };
            var anjunadeep = new Label {Name = "Anjunadeep", CoverUrl = "https://geo-media.beatport.com/image/14195883.jpg" };
            var drumcode = new Label {Name = "Drumcode", CoverUrl = "https://geo-media.beatport.com/image/12006709.jpg"};
            var suara = new Label {Name = "Suara", CoverUrl = "https://geo-media.beatport.com/image/11107394.jpg" };

            var techHouse = _context.Genres.Find(1);
            var techno = _context.Genres.Find(2);

            var sheeple = new Release
            {
                Name = "Sheeple",
                Artists = new List<Artist> {greenVelvet, prokAndFitch},
                ReleaseDate = new DateTime(2016, 11, 18),
                CoverUrl = "https://geo-media.beatport.com/image/14788499.jpg",
                Genre = techHouse,
                Label = relief,
                Tracks = new List<Track>
                {
                    new Track
                    {
                        Number = 1,
                        Name = "Sheeple",
                        Length = DateHelper.GetSeconds(7, 1),
                        BPM = 124,
                        Key = Keys.Amin,
                        Genre = techHouse
                    }
                }
            };

            var swagonEp = new Release
            {
                Name = "Swagon EP",
                Artists = new List<Artist> {detlef, osseyJames},
                ReleaseDate = new DateTime(2017, 1, 13),
                CoverUrl = "https://geo-media.beatport.com/image/15086682.jpg",
                Genre = techHouse,
                Label = repopulateMars,
                Tracks = new List<Track>
                {
                    new Track
                    {
                        Number = 1,
                        Name = "Swagon feat. Ossey James",
                        Length = DateHelper.GetSeconds(6, 12),
                        BPM = 125,
                        Key = Keys.Bmaj,
                        Genre = techHouse
                    },
                    new Track
                    {
                        Number = 2,
                        Name = "Pump Up",
                        Length = DateHelper.GetSeconds(7, 23),
                        BPM = 124,
                        Key = Keys.Fsharpmin,
                        Genre = techHouse
                    },
                    new Track
                    {
                        Number = 3,
                        Name = "My Home",
                        Length = DateHelper.GetSeconds(6, 40),
                        BPM = 122,
                        Key = Keys.Cmin,
                        Genre = techHouse
                    }
                }
            };

            var deadEndThrills = new Release
            {
                Name = "Dead End Thrills",
                Artists = new List<Artist> {patriceBaumel, cubicolor},
                ReleaseDate = new DateTime(2017, 1, 13),
                CoverUrl = "https://geo-media.beatport.com/image/15040687.jpg",
                Genre = techHouse,
                Label = anjunadeep,
                Tracks = new List<Track>
                {
                    new Track
                    {
                        Number = 1,
                        Name = "Dead End Thrills",
                        Length = DateHelper.GetSeconds(7, 23),
                        BPM = 122,
                        Key = Keys.Amaj,
                        Genre = techHouse
                    }
                }
            };

            var chemistry = new Release
            {
                Name = "Chemistry",
                Artists = new List<Artist> {pigAndDan},
                ReleaseDate = new DateTime(2016, 11, 28),
                CoverUrl = "https://geo-media.beatport.com/image/14868687.jpg",
                Genre = techno,
                Label = drumcode,
                Tracks = new List<Track>
                {
                    new Track
                    {
                        Number = 1,
                        Name = "Chemistry",
                        Length = DateHelper.GetSeconds(8, 15),
                        BPM = 124,
                        Key = Keys.Bmin,
                        Genre = techno
                    },
                    new Track
                    {
                        Number = 2,
                        Name = "Ukraine",
                        Length = DateHelper.GetSeconds(7, 24),
                        BPM = 126,
                        Key = Keys.Amin,
                        Genre = techno
                    },
                    new Track
                    {
                        Number = 3,
                        Name = "Devotion",
                        Length = DateHelper.GetSeconds(8, 7),
                        BPM = 126,
                        Key = Keys.Amaj,
                        Genre = techno
                    }
                }
            };

            var everybodyEp = new Release
            {
                Name = "Everybody EP",
                Artists = new List<Artist> {dennisCruz},
                ReleaseDate = new DateTime(2016, 10, 31),
                CoverUrl = "https://geo-media.beatport.com/image/14738704.jpg",
                Genre = techHouse,
                Label = suara,
                Tracks = new List<Track>
                {
                    new Track
                    {
                        Number = 1,
                        Name = "Everybody",
                        Length = DateHelper.GetSeconds(6, 51),
                        BPM = 123,
                        Key = Keys.Amin,
                        Genre = techHouse
                    },
                    new Track
                    {
                        Number = 2,
                        Name = "Nature Boy",
                        Length = DateHelper.GetSeconds(9, 2),
                        BPM = 123,
                        Key = Keys.Emaj,
                        Genre = techno
                    },
                    new Track
                    {
                        Number = 3,
                        Name = "Body Flow",
                        Length = DateHelper.GetSeconds(6, 36),
                        BPM = 122,
                        Key = Keys.Gmin,
                        Genre = techHouse
                    }
                }
            };

            _context.Releases.AddRange(new List<Release> { sheeple, swagonEp, deadEndThrills, chemistry, everybodyEp });

            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return new EmptyResult();
        }

        public EmptyResult CleanDb()
        {
            _context.Artists.RemoveRange(_context.Artists);
            _context.Releases.RemoveRange(_context.Releases);
            _context.Labels.RemoveRange(_context.Labels);
            _context.SaveChanges();

            return new EmptyResult();
        }
    }
}