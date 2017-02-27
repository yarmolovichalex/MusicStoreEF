using MusicStoreEF.Models;
using System.Collections.Generic;

namespace MusicStoreEF.Repositories
{
    public interface IGenreRepository
    {
        Genre GetById(byte id);
        IEnumerable<Genre> GetAll();
    }
}