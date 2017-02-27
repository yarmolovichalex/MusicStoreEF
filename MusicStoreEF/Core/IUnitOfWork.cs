﻿using MusicStoreEF.Core.Repositories;

namespace MusicStoreEF.Core
{
    public interface IUnitOfWork
    {
        IArtistRepository Artists { get; }
        IGenreRepository Genres { get; }
        ILabelRepository Labels { get; }
        IReleaseRepository Releases { get; }
        ITrackRepository Tracks { get; }

        void Complete();
    }
}