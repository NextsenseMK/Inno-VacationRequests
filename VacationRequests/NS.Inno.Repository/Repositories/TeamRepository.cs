using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository.Repositories
{
    public class TeamRepository:IRepository<Team>
    {
        private VacationRequestsContext context = null;

        public TeamRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<Team> GetAll(Func<Team, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.Teams.Where(predicate);
            }

            return context.Teams;
        }

        public Team Get(Func<Team, bool> predicate)
        {
            return context.Teams.FirstOrDefault(predicate);
        }

        public void Add(Team entity)
        {
            context.Teams.Add(entity);
        }

        public void Update(Team entity)
        {
            context.Teams.Update(entity);
        }

        public void Attach(Team entity)
        {
            context.Teams.Attach(entity);
        }

        public void Delete(Team entity)
        {
            context.Teams.Remove(entity);
        }
    }
}
