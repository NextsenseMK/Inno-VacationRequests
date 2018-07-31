using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface IVacationRequestSystem
    {
        void CreateVacationRequest(VacationRequest vacationRequest);
        void UpdateVacationRequest(VacationRequest vacationRequest);
        VacationRequest GeVacationRequest(int id);
        void DeleteVacationRequest(int id);
    }
}
