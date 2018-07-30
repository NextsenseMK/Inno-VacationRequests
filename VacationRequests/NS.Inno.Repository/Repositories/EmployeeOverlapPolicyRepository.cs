using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository.Repositories
{
    public class EmployeeOverlapPolicyRepository : IRepository<EmployeeOverlapPolicy>
    {
        private VacationRequestsContext context = null;

        public EmployeeOverlapPolicyRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<EmployeeOverlapPolicy> GetAll(Func<EmployeeOverlapPolicy, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.EmployeeOverlapPolicies.Where(predicate);
            }

            return context.EmployeeOverlapPolicies;
        }

        public EmployeeOverlapPolicy Get(Func<EmployeeOverlapPolicy, bool> predicate)
        {
            return context.EmployeeOverlapPolicies.FirstOrDefault(predicate);
        }

        public void Add(EmployeeOverlapPolicy entity)
        {
            context.EmployeeOverlapPolicies.Add(entity);
        }

        public void Update(EmployeeOverlapPolicy entity)
        {
            context.EmployeeOverlapPolicies.Update(entity);
        }

        public void Attach(EmployeeOverlapPolicy entity)
        {
            context.EmployeeOverlapPolicies.Attach(entity);
        }

        public void Delete(EmployeeOverlapPolicy entity)
        {
            context.EmployeeOverlapPolicies.Remove(entity);
        }
    }
}
