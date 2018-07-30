using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository.Repositories
{
    public class VacationDaysRepository:IRepository<VacationDays>
    {
        private VacationRequestsContext context = null;

        public VacationDaysRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<VacationDays> GetAll(Func<VacationDays, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.VacationDays.Where(predicate);
            }

            return context.VacationDays;
        }

        public VacationDays Get(Func<VacationDays, bool> predicate)
        {
            return context.VacationDays.FirstOrDefault(predicate);
        }

        public void Add(VacationDays entity)
        {
            context.VacationDays.Add(entity);
        }

        public void Update(VacationDays entity)
        {
            context.VacationDays.Update(entity);
        }

        public void Attach(VacationDays entity)
        {
            context.VacationDays.Attach(entity);
        }

        public void Delete(VacationDays entity)
        {
            context.VacationDays.Remove(entity);
        }
    }
}
