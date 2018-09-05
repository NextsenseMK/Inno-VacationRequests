using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Options;
using NS.Inno.Business.Interfaces;
using NS.Inno.Common;
using NS.Inno.Models;
using NS.Inno.Repository;

namespace NS.Inno.Business.Implementations
{
    public class TeamSystem : ITeamSystem
    {
        private readonly ConfigProvider _configProvider;
        private readonly IUnitOfWork _unitOfWork;
        public TeamSystem(IOptions<ConfigProvider> configProvider, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _configProvider = configProvider.Value;
        }
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
            return null;
            //var list = scope.ApprovingLevelRepository.GetAll().Join(scope.VacationRequestRepository.GetAll(),
            //    appLevel => appLevel.VacationRequest.Id,
            //    vacRequest => vacRequest.Id,
            //    (appLevel, vacRequest) => new { AppLevel = appLevel, VacRequest = vacRequest }).ToList();
        }
    }
}
