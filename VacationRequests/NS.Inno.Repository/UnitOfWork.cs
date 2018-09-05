using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NS.Inno.Common;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private VacationRequestsContext _context { get; }

        public UnitOfWork(VacationRequestsContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IRepository<ApprovingLevel> ApprovingLevelRepository => new Repository<ApprovingLevel>(_context);
        public IRepository<EmployeeOverlapPolicy> EmployeeOverlapPolicyRepository => new Repository<EmployeeOverlapPolicy>(_context);
        public IRepository<Team> TeamRepository => new Repository<Team>(_context);
        public IRepository<User> UserRepository => new Repository<User>(_context);
        public IRepository<VacationDays> VacationDaysRepository => new Repository<VacationDays>(_context);
        public IRepository<VacationRequest> VacationRequestRepository => new Repository<VacationRequest>(_context);
    }
}
