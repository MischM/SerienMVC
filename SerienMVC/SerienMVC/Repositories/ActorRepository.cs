using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerienMVC.Repositories
{
    public class ActorRepository : Repository<Actor>, IActorRepository
    {
        public ActorRepository(SerienDBEntities context) : base(context)
        {
        }
    }
}