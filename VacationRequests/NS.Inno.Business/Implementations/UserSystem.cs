using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
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
        private readonly ConfigProvider _configProvider;
        private readonly IUnitOfWork _unitOfWork;

        public UserSystem(IOptions<ConfigProvider> configProvider, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _configProvider = configProvider.Value;
        }

        public void CreateUser(User user)
        {

            //dummy
            using (var scope = new TransactionScope())
            {
                user = new User();
               var  user1 = new User();


                user.Active = true;
                user.DisplayName = "Tanja";
                user.EmploymentDate = DateTime.Now;
                user.Role = UserRoleEnum.Managment;

                _unitOfWork.UserRepository.Add(user);
                _unitOfWork.SaveChanges();
                user1.Active = true;
                user1.DisplayName = "kiki";
                user1.EmploymentDate = DateTime.Now;
                user1.Role = UserRoleEnum.HumanResource;

                _unitOfWork.UserRepository.Add(user1);
                _unitOfWork.SaveChanges();
                scope.Complete();

            }

        }

        public void Updateuser(User user)
        {
            throw new NotImplementedException();
        }

        public bool CheckUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {

            var p = _configProvider.ConnectionString;
            return _unitOfWork.UserRepository.GetAll().FirstOrDefault();

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
