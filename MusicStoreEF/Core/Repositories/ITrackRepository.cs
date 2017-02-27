using System.Collections.Generic;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Core.Repositories
{
    public interface ITrackRepository
    {
        IEnumerable<Track> GetAll();
    }
}