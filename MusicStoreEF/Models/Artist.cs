using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}