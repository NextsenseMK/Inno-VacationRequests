using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface IUserSystem
    {
        void CreateUser(User user);
        void Updateuser(User user);
        bool CheckUser(User user);
        User GetUser(int id);
        List<User> GetAllTeamLeaders();
        List<Team> GetTeamsWhereThisUserIsTeamLead(User user);
    }
}
