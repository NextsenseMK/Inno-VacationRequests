using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private VacationRequestsContext _context { get; }

        public Repository(VacationRequestsContext context )
        {
            _context = context;
        }

        public virtual IEnumerable<T> GetAll(
            List<Expression<Func<T, bool>>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int Page = 0,
            params Expression<Func<T, object>>[] included)
        {

            IQueryable<T> query = _context.Set<T>();

            foreach (var z in included)
            {
                query = query.Include(z);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
                query = query.Skip((Page - 1) * 30).Take(30);
            }
            if (filter != null)
            {
                foreach (var z in filter)
                {
                    query = query.Where(z);
                }
            }
            return query.ToList();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public virtual T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void DeleteById(object id)
        {
            T entityToDelete = _context.Set<T>().Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            T existing = _context.Set<T>().Find(entityToDelete);
            if (existing != null) _context.Set<T>().Remove(existing);
        }

        public virtual void Update(T entityToUpdate)
        {
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            _context.Set<T>().Attach(entityToUpdate);
        }
        public IQueryable<T> Query()
        {
            return _context.Query<T>();
        }
    }
}
