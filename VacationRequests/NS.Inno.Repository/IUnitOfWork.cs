using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Data;
using NS.Inno.Models;

namespace NS.Inno.Repository
{
    public interface IUnitOfWork
    {  
        void SaveChanges();

        IRepository<ApprovingLevel> ApprovingLevelRepository { get; }
        IRepository<EmployeeOverlapPolicy> EmployeeOverlapPolicyRepository { get; }
        IRepository<Team> TeamRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<VacationDays> VacationDaysRepository { get; }
        IRepository<VacationRequest> VacationRequestRepository { get; }
    }
}
