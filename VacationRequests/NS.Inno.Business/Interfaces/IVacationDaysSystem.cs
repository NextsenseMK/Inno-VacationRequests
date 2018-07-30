using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface IVacationDaysSystem
    {
        void CreateVacationDays(VacationDays vacationDays);
        void UpdateVacationDays(VacationDays vacationDays);
        int GetReaminingVacationDaysByUser(User user);
    }
}
