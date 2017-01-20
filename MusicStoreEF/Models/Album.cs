using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}