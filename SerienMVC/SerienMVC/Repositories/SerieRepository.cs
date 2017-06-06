using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerienMVC.Repositories
{
    public class SerieRepository : Repository<Serie>, ISerieRepository
    {
        public SerieRepository(SerienDBEntities context) : base(context)
        {
        }

        public Serie GetSerieWithActor(int id)
        {
            //todo
            return null;
        }

        public Serie GetSerieWithGenre(int id)
        {
            //todo
            return null;
        }
    }
}