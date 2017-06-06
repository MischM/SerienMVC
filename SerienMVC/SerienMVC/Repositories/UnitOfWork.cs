using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerienMVC.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SerienDBEntities _context;
        public UnitOfWork(SerienDBEntities context)
        {
            _context = context;
            Serie = new SerieRepository(_context);
            Actor = new ActorRepository(_context);
            Genre = new GenreRepository(_context);
        }
        public IActorRepository Actor { get; private set; }

        public IGenreRepository Genre { get; private set; }

        public ISerieRepository Serie { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}