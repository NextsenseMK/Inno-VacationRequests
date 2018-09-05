using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository
{
    public interface IRepository<T> where T : class
    {
        //IQueryable<T> Query();
        IEnumerable<T> GetAll(
            List<Expression<Func<T, bool>>> filter,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int Page = 0,
            params Expression<Func<T, object>>[] included);

        T GetById(object id);
        T Get(Func<T, bool> predicate);
        void Insert(T entity);
        void DeleteById(object id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        IQueryable<T> Query();
    }
}
