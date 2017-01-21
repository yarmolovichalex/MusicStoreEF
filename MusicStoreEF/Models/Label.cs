using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Label
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverUrl { get; set; }
        public ICollection<Release> Releases { get; set; }
    }
}