using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FixingIT.Domain.Entities.Abstract;
using System.Data.Entity;

namespace FixingIT.Domain.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        DbContext Model { get; }

        IQueryable<T> FindAll(Func<T, bool> filter = null);
        T FindByID(int id);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);
        void Commit();
    }
}