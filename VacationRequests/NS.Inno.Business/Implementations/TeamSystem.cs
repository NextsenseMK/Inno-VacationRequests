using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NS.Inno.Business.Interfaces;
using NS.Inno.Models;
using NS.Inno.Repository;

namespace NS.Inno.Business.Implementations
{
    public class TeamSystem : ITeamSystem
    {
        public User GetTeamLeader(Team team)
        {
            throw new NotImplementedException();
        }

        public Team GetMyTeam(User user)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetAllTeams()
        {
            using (var scope = new UnitOfWork())
            {
                return scope.TeamRepository.GetAll().ToList();
            }

            //var list = scope.ApprovingLevelRepository.GetAll().Join(scope.VacationRequestRepository.GetAll(),
            //    appLevel => appLevel.VacationRequest.Id,
            //    vacRequest => vacRequest.Id,
            //    (appLevel, vacRequest) => new { AppLevel = appLevel, VacRequest = vacRequest }).ToList();
        }
    }
}
