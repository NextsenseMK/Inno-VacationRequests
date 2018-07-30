using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;
using NS.Inno.Repository;

namespace NS.Inno.Repository.Repositories
{
    public class UserRepository:IRepository<User>
    {
        private VacationRequestsContext context = null;

        public UserRepository(VacationRequestsContext _context)
        {
            context = _context;
        }
        public IEnumerable<User> GetAll(Func<User, bool> predicate = null)
        {
            if (predicate != null)
            {
                return context.Users.Where(predicate);
            }

            return context.Users;
        }

        public User Get(Func<User, bool> predicate)
        {
            return context.Users.FirstOrDefault(predicate);
        }

        public void Add(User entity)
        {
            context.Users.Add(entity);
        }

        public void Update(User entity)
        {
            context.Users.Update(entity);
        }

        public void Attach(User entity)
        {
            context.Users.Attach(entity);
        }

        public void Delete(User entity)
        {
            context.Users.Remove(entity);
        }
    }
}
