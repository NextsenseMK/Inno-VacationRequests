using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Xml.Linq;
using Microsoft.Extensions.Options;
using NS.Inno.Business.Interfaces;
using NS.Inno.Common;
using NS.Inno.Common.Enums;
using NS.Inno.Models;
using NS.Inno.Repository;

namespace NS.Inno.Business.Implementations
{
    public class UserSystem : IUserSystem
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserSystem(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateUser(User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.SaveChanges();
        }

        public void Updateuser(User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.SaveChanges();
        }

        public bool CheckUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return _unitOfWork.UserRepository.GetById(id);
        }

        public List<User> GetAllTeamLeaders()
        {
            return _unitOfWork.UserRepository.Query().Where(x => x.Role == UserRoleEnum.TeamLeader).ToList();
        }

        public List<Team> GetTeamsWhereThisUserIsTeamLead(User user)
        {
             return _unitOfWork.TeamRepository.Query().Where(x => x.Id == user.Team.Id && user.Role == UserRoleEnum.TeamLeader).ToList();
        }
    }
}
