using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class GenreVm
    {
        public string Genre { get; set; }
        public IEnumerable<ReleaseVm> Releases { get; set; }
    }
}