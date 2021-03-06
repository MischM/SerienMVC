﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerienMVC.Repositories
{
    public interface ISerieRepository:IRepository<Serie>
    {
        List<Serie> GetSerieWithActors(int id);
        List<Serie> GetSerieWithGenres(int id);
        List<Serie> GetAllSeries(); //With Genre and Actors
    }
}
