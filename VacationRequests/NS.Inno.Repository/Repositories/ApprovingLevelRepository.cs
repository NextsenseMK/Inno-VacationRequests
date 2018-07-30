using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository.Repositories
{
    public class ApprovingLevelRepository:IRepository<ApprovingLevel>
    {
        private VacationRequestsContext context = null;

        public ApprovingLevelRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<ApprovingLevel> GetAll(Func<ApprovingLevel, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.ApprovingLevels.Where(predicate);
            }

            return context.ApprovingLevels;
        }

        public ApprovingLevel Get(Func<ApprovingLevel, bool> predicate)
        {
            return context.ApprovingLevels.FirstOrDefault(predicate);
        }

        public void Add(ApprovingLevel entity)
        {
            context.ApprovingLevels.Add(entity);
        }

        //public IQueryable<ApprovingLevel> Query()
        //{
        //    return context.Query<ApprovingLevel>();
        //}

        public void Update(ApprovingLevel entity)
        {
            context.ApprovingLevels.Update(entity);
        }

        public void Attach(ApprovingLevel entity)
        {
            context.ApprovingLevels.Attach(entity);
        }

        public void Delete(ApprovingLevel entity)
        {
            context.ApprovingLevels.Remove(entity);
        }
        
    }
}
