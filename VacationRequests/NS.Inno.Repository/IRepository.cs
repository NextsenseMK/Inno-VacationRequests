using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Repository
{
    public interface IRepository<T> where T : class
    {
        //IQueryable<T> Query();
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        T Get(Func<T, bool> predicate);
        void Add(T entity);
        void Update(T entity);
        void Attach(T entity);
        void Delete(T entity);
    }
}
