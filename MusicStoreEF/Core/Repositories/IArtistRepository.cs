using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Core.Repositories
{
    public interface IArtistRepository
    {
        Artist GetById(int id);
        void RemoveAll();
    }
}