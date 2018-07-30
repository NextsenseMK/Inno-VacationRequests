using System;
using System.Collections.Generic;
using System.Text;
using NS.Inno.Models;

namespace NS.Inno.Business.Interfaces
{
    public interface ITeamSystem
    {
        User GetTeamLeader(Team team);
        Team GetMyTeam(User user);
    }
}
