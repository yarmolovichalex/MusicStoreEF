using System.Collections.Generic;
using MusicStoreEF.Core.Models;

namespace MusicStoreEF.Core.Repositories
{
    public interface IGenreRepository
    {
        Genre GetById(byte id);
        IEnumerable<Genre> GetAll();
    }
}