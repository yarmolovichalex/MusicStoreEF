using MusicStoreEF.Models;
using System;
using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class ReleaseDetailsVm
    {
        public string Name { get; set; }
        public ICollection<ArtistVm> Artists { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Label Label { get; set; }
        public string CoverUrl { get; set; }
        public IEnumerable<TrackVm> Tracks { get; set; }
    }
}