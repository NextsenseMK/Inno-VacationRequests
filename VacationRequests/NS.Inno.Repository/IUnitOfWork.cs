using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Repository.Repositories;

namespace NS.Inno.Repository
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void Dispose();

        ApprovingLevelRepository ApprovingLevelRepository { get; }
        EmployeeOverlapPolicyRepository EmployeeOverlapPolicyRepository { get;  }
        TeamRepository TeamRepository { get; }
        UserRepository UserRepository { get;}
        VacationDaysRepository VacationDaysRepository { get; }
        VacationRequestRepository VacationRequestRepository { get; }
    }
}
