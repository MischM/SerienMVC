using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerienMVC.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(SerienDBEntities context) : base(context)
        {
        }
    }
}