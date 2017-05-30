using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerienMVC.Repositories
{
    interface ISerieRepository:IRepository<Serie>
    {
        Serie GetSerieWithActor(int id);
        Serie GetSerieWithGenre(int id);
    }
}
