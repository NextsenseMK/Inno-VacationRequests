using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NS.Inno.Common.Enums;
using NS.Inno.Models;

namespace NS.Inno.Web.Controllers
{
    public class UserController : Controller
    {
        public JsonResult GetUsers()
        {
            return Json(new List<User>() {
                new User { Id = 1,Active = true,DisplayName = "Tanja Stojanovska",UserName = "ns\\tanjas",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now,},
                new User { Id = 1,Active = true,DisplayName = "Vladimir Nikolovski",UserName = "ns\\vladimirn",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Pepi Manchev",UserName = "ns\\pepim",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Valentina Dimovska",UserName = "ns\\valendtinad",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Aleksandar Dimitrievski",UserName = "ns\\aleksandardim",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Tome Trajkov",UserName = "ns\\tomet",Role = UserRoleEnum.User,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Darko Milevski",UserName = "ns\\darko",Role = UserRoleEnum.TeamLeader,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
                new User { Id = 1,Active = true,DisplayName = "Elena Markovska",UserName = "ns\\elenam",Role = UserRoleEnum.Administrator,Team = new Team { Id = 1,Active = true,Name = "Darko's Team"},EmploymentDate = DateTime.Now},
               
            });
        }
    }
}