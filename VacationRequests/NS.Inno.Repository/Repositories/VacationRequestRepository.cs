using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository.Repositories
{
    public class VacationRequestRepository:IRepository<VacationRequest>
    {
        private VacationRequestsContext context = null;

        public VacationRequestRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<VacationRequest> GetAll(Func<VacationRequest, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.VacationRequests.Where(predicate);
            }

            return context.VacationRequests;
        }

        public VacationRequest Get(Func<VacationRequest, bool> predicate)
        {
            return context.VacationRequests.FirstOrDefault(predicate);
        }

        public void Add(VacationRequest entity)
        {
            context.VacationRequests.Add(entity);
        }

        public void Update(VacationRequest entity)
        {
            context.VacationRequests.Update(entity);
        }

        public void Attach(VacationRequest entity)
        {
            context.VacationRequests.Attach(entity);
        }

        public void Delete(VacationRequest entity)
        {
            context.VacationRequests.Remove(entity);
        }
    }
}
