using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerienMVC.Repositories
{
    interface IUnitOfWork : IDisposable
    {
        ISerieRepository Serie { get; }
        IActorRepository Actor { get; }
        IGenreRepository Genre { get; }
        int Complete();
    }
}
