using MusicStoreEF.Models;
using System.Collections.Generic;

namespace MusicStoreEF.Repositories
{
    public interface IReleaseRepository
    {
        IEnumerable<Release> GetLatestReleases();
        Release GetById(int id);
        IEnumerable<Release> GetByGenre(byte genre);
        void Add(IEnumerable<Release> releases);
        void RemoveAll();
    }
}