using System;

namespace MusicStoreEF.ViewModels
{
    public class ReleaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artists { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public decimal Price { get; set; }
    }
}