using System;
using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class ReleaseVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ArtistVm> Artists { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<TrackToListenVm> Tracks { get; set; }
    }
}