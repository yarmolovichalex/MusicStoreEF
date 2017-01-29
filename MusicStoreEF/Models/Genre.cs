using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public ICollection<Release> Releases { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}