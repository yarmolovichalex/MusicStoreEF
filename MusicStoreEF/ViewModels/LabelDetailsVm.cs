using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class LabelDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CoverUrl { get; set; }
        public IEnumerable<ReleaseVm> Releases { get; set; }
    }
}