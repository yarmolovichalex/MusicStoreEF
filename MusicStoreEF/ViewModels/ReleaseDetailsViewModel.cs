using MusicStoreEF.Models;
using System;
using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class ReleaseDetailsViewModel
    {
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Label { get; set; }
        public string CoverUrl { get; set; }
        public IEnumerable<TrackViewModel> Tracks { get; set; }
    }
}