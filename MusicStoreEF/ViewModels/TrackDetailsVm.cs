using System;
using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class TrackDetailsVm
    {
        public string Name { get; set; }
        public int ReleaseId { get; set; }
        public string ReleaseCoverUrl { get; set; }
        public ICollection<ArtistVm> Artists { get; set; }
        public LabelVm Label { get; set; }
        public string Genre { get; set; }
        public string Key { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}