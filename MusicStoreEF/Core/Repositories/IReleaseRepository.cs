using System.Collections.Generic;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Core.Repositories
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