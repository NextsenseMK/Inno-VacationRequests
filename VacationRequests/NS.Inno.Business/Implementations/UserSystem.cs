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
        private readonly IUnitOfWork _unitOfWork;

        public UserSystem(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //GetUser(1);
            //CreateUser(new User());
        }

        public void CreateUser(User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.SaveChanges();

            //var userForCreate12 = new User
            //{
            //    UserName = "UserName33322",
            //    DisplayName = "DisplayName112",
            //    EmploymentDate = DateTime.Now,
            //    Role = UserRoleEnum.Administrator
            //};
            //_unitOfWork.UserRepository.Insert(userForCreate12);
            //_unitOfWork.SaveChanges();

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
            var a = _unitOfWork.UserRepository.GetById(id);
            return a;

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
