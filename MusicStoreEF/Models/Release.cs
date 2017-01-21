using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreEF.Models
{
    public class Release
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public Label Label { get; set; }
        public int LabelId { get; set; }

        public string FormattedArtists => string.Join(", ", Artists.Select(x => x.Name).OrderBy(x => x));
    }
}