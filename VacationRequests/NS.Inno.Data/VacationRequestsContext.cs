using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NS.Inno.Models;

namespace NS.Inno.Data
{
    public class VacationRequestsContext : DbContext
    {
        public VacationRequestsContext(DbContextOptions<VacationRequestsContext> options): base(options)
        { }

        public DbSet<ApprovingLevel> ApprovingLevels { get; set; }
        public DbSet<EmployeeOverlapPolicy> EmployeeOverlapPolicies { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VacationDays> VacationDays { get; set; }
        public DbSet<VacationRequest> VacationRequests { get; set; }

    }
}
