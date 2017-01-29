using System;
using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Release
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public Label Label { get; set; }
        public int LabelId { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}