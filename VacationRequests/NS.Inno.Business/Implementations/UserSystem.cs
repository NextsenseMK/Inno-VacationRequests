using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Business.Interfaces;
using NS.Inno.Models;

namespace NS.Inno.Business.Implementations
{
    public class UserSystem : IUserSystem
    {
        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Updateuser(User user)
        {
            throw new NotImplementedException();
        }

        public bool CheckUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllTeamLeaders()
        {
            throw new NotImplementedException();
        }

        public List<Team> GetTeamsWhereThisUserIsTeamLead(User user)
        {
            throw new NotImplementedException();
        }
    }
}
