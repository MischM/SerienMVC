﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SerienMVC.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SerienDBEntities Context;

        public Repository(SerienDBEntities context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {
            // While working with a DbContext we need to use the generic Set() method to access them.
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            if (orderBy != null)
            {
                IQueryable<TEntity> query = Context.Set<TEntity>();
                return orderBy(query).ToList();
                //DbSet<TEntity> dbSet = Context.Set<TEntity>();
                //IQueryable<TEntity> query = dbSet;
                //return orderBy(query).ToList();
            }
            else
            {
                return Context.Set<TEntity>().ToList();
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Attach(entity);
            //IDbSet<TEntity> dbSet = Context.Set<TEntity>();
            //dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}