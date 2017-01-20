namespace MusicStoreEF.Models
{
    public class Track
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
    }
}