using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NS.Inno.Data;
using NS.Inno.Models;
using NS.Inno.Repository.Repositories;

namespace NS.Inno.Repository
{
    public class UnitOfWork : IDisposable
    {
        private VacationRequestsContext _context = null;

        ApprovingLevelRepository _approvingLevelRepository = null;
        EmployeeOverlapPolicyRepository _employeeOverlapPolicyRepository = null;
        TeamRepository _teamRepository = null;
        UserRepository _userRepository = null;
        VacationDaysRepository _vacationDaysRepository = null;
        VacationRequestRepository _vacationRequestRepository = null;

        private bool disposed = false;

        public UnitOfWork()
        {
            var optionsBuilder = new DbContextOptionsBuilder<VacationRequestsContext>();
            optionsBuilder.UseSqlServer("Server = VLADIMIRN-LT;Database = VacationRequests; Trusted_Connection = True;");

            _context = new VacationRequestsContext(optionsBuilder.Options);
        }

        public ApprovingLevelRepository ApprovingLevelRepository => new ApprovingLevelRepository(_context);
        public EmployeeOverlapPolicyRepository EmployeeOverlapPolicyRepository => new EmployeeOverlapPolicyRepository(_context);
        public TeamRepository TeamRepository => new TeamRepository(_context);
        public UserRepository UserRepository => new UserRepository(_context);
        public VacationDaysRepository VacationDaysRepository => new VacationDaysRepository(_context);
        public VacationRequestRepository VacationRequestRepository => new VacationRequestRepository(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
