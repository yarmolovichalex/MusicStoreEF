namespace MusicStoreEF.ViewModels
{
    public class TrackVm
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int? BPM { get; set; }
        public string Key { get; set; }
        public int Length { get; set; }
        public string AudioUrl { get; set; }
    }
}