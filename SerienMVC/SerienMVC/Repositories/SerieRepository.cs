using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SerienMVC.Repositories
{
    public class SerieRepository : Repository<Serie>, ISerieRepository
    {
        public SerieRepository(SerienDBEntities context) : base(context)
        {
        }

        public List<Serie> GetSerieWithActors(int id)
        {
            return SerienDBEntities
                .Serie
                .Where(s => s.ID == id)
                .Include("Actor")
                .ToList();
        }

        public List<Serie> GetSerieWithGenres(int id)
        {
            return SerienDBEntities
                .Serie
                .Where(s => s.ID == id)
                .Include("Genre")
                .ToList();
        }
        public SerienDBEntities SerienDBEntities
        {
            get { return Context as SerienDBEntities; }
        }
    }
}