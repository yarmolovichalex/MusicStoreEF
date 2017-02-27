using System.Collections.Generic;
using System.Linq;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.ViewModels
{
    public static class ViewModelMappers
    {
        public static IEnumerable<ReleaseVm> ToReleaseVms(this IEnumerable<Release> releases)
        {
            return releases.Select(r => r.ToReleaseVm());
        }

        public static IEnumerable<ArtistVm> ToArtistVms(this IEnumerable<Artist> artists)
        {
            return artists.Select(a => a.ToArtistVm());
        }

        public static IEnumerable<TrackVm> ToTrackVms(this IEnumerable<Track> tracks)
        {
            return tracks.Select(t => t.ToTrackVm());
        }

        public static ReleaseVm ToReleaseVm(this Release release)
        {
            return new ReleaseVm
            {
                Id = release.Id,
                Name = release.Name,
                Artists = release.Artists.Select(a => a.ToArtistVm()).ToList(),
                ReleaseDate = release.ReleaseDate,
                Genre = release.Genre.Name,
                CoverUrl = release.CoverUrl,
                Price = release.Price
            };
        }

        public static ArtistVm ToArtistVm(this Artist artist)
        {
            return new ArtistVm
            {
                Id = artist.Id,
                Name = artist.Name
            };
        }

        public static TrackVm ToTrackVm(this Track track)
        {
            return new TrackVm
            {
                Number = track.Number,
                Name = track.Name,
                Genre = track.Genre.Name,
                BPM = track.BPM,
                Key = track.Key,
                Length = track.Length
            };
        }
    }
}