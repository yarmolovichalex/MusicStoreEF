﻿using MusicStoreEF.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicStoreEF.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IDbContext _context;

        public GenreRepository(IDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetAll()
        {
            return _context.Genres.ToList();
        }

        public Genre GetById(byte id)
        {
            return _context.Genres.SingleOrDefault(g => g.Id == id);
        }
    }
}