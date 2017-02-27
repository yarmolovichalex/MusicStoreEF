﻿using MusicStoreEF.Models;

namespace MusicStoreEF.Repositories
{
    public interface IArtistRepository
    {
        Artist GetById(int id);
        void RemoveAll();
    }
}