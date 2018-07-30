using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface IApprovingLevelSystem
    {
        void CreateApprovingLevel(ApprovingLevel approvingLevel);
        void UpdateApprovingLevel(ApprovingLevel approvingLevel);
        ApprovingLevel GetApprovingLevel();
        List<ApprovingLevel> GetAllApprovingLevels();
    }
}
