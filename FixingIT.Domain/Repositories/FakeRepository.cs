using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FixingIT.Domain.Entities.Abstract;
using FixingIT.Domain.Repositories.Abstract;
using System.Data.Entity;

namespace FixingIT.Domain.Repositories
{
    public class FakeRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected List<T> context;

        public FakeRepository(params T[] entities)
        {
            context = entities.ToList();
        }

        public DbContext Model { get { return null; } }

        public virtual IQueryable<T> FindAll(Func<T,bool> filter = null)
        {
            if (null == filter)
                return context.AsQueryable();
            return context.Where(filter).AsQueryable();
        }

        public virtual T FindByID(int id)
        {
            return context.Find(e => e.ID == id);
        }

        public virtual void Update(T entity)
        {
            var existing = context.Where(e => e.ID == entity.ID).FirstOrDefault();
            if (null != existing)
                context[context.IndexOf(existing)] = entity;
            else
                context.Add(entity);
        }

        public virtual void Add(T entity)
        {
            var existing = context.Where(e => e.ID == entity.ID).FirstOrDefault();
            if (null != existing)
                throw new Exception(string.Format("Entity {0} already exists", entity.ToString()));
            else
                context.Add(entity);
        }

        private int _deleteCallCount;
        private IEntity _lastDeleteArgument;
        public int DeleteCallCount { get { return _deleteCallCount; } }
        public IEntity LastDeleteArgument { get { return _lastDeleteArgument; } }
        public virtual void Delete(T entity)
        {
            _deleteCallCount++;
            _lastDeleteArgument = entity;
            context.Remove(entity);
        }
        

        public virtual void Commit() { }
    }
}