using System.Collections.Generic;

namespace MusicStoreEF.Models
{
    public class Track
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Genre { get; set; }
        public int? BPM { get; set; }
        public string Key { get; set; }

        public Release Release { get; set; }
        public int ReleaseId { get; set; }
    }
}