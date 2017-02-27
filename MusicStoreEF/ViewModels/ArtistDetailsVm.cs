using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class ArtistDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public IEnumerable<ReleaseVm> Releases { get; set; }
    }
}