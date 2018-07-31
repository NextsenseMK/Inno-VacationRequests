using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface IEmployeeOverlapPolicySystem
    {
        void CreateEmployeeOverlapPolicy(EmployeeOverlapPolicy employeeOverlapPolicy);
        void UpdateEmployeeOverlapPolicy(EmployeeOverlapPolicy employeeOverlapPolicy);
        EmployeeOverlapPolicy GetEmployeeOverlapPolicy(int id);
        List<EmployeeOverlapPolicy> GetAllEmployeeOverlapPolicies();
        void DeleteEmployeeOverlapPolicy(int id);
    }
}
