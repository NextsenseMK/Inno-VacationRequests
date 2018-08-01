using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NS.Inno.Common;
using NS.Inno.Data;
using NS.Inno.Models;
using NS.Inno.Repository.Repositories;

namespace NS.Inno.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private VacationRequestsContext _context = null;

        private bool disposed = false;
        private readonly ConfigProvider _configProvider;
        public UnitOfWork(IOptions<ConfigProvider> configProvider)
        {
            _configProvider = configProvider.Value;
            var optionsBuilder = new DbContextOptionsBuilder<VacationRequestsContext>();
            optionsBuilder.UseSqlServer("Server = PEPIM2013-PC;Database = VacationRequests; Trusted_Connection = True;");

            _context = new VacationRequestsContext(optionsBuilder.Options);
        }

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

        public ApprovingLevelRepository ApprovingLevelRepository { get => new ApprovingLevelRepository(_context); }
        public EmployeeOverlapPolicyRepository EmployeeOverlapPolicyRepository { get => new EmployeeOverlapPolicyRepository(_context); }
        public TeamRepository TeamRepository { get => new TeamRepository(_context); }
        public UserRepository UserRepository { get => new UserRepository(_context); }
        public VacationDaysRepository VacationDaysRepository { get => new VacationDaysRepository(_context); }
        public VacationRequestRepository VacationRequestRepository { get => new VacationRequestRepository(_context); }
    }
}
