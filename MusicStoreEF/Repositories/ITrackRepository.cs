using System.Collections.Generic;
using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public interface ITrackRepository
    {
        IEnumerable<Track> GetAll();
    }
}