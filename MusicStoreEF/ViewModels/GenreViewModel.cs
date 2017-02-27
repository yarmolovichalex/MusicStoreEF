using MusicStoreEF.Models;
using System.Collections.Generic;

namespace MusicStoreEF.ViewModels
{
    public class GenreViewModel
    {
        public string Genre { get; set; }
        public ICollection<Release> Releases { get; set; }
    }
}