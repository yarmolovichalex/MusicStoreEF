using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public interface IArtistRepository
    {
        Artist GetArtistWithReleases(int id);
    }
}