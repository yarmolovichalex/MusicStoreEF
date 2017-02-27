using System.Collections.Generic;

namespace MusicStoreEF.Core.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public ICollection<Release> Releases { get; set; }
    }
}