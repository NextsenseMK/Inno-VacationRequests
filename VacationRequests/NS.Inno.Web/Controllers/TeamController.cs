using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NS.Inno.Common.Enums;
using NS.Inno.Models;

namespace NS.Inno.Web.Controllers
{
    public class TeamController : Controller
    {
        public JsonResult GetTeams()
        {
            return Json(new List<Team>() {
                new Team { Id = 1,Active = true,Name = "Darko's Team", TeamLeaders = new List<User>{ new User { Id = 1,Active = true,DisplayName = "Darko Milevski",UserName = "ns\\darko",Role = UserRoleEnum.TeamLeader,Team = null,EmploymentDate = DateTime.Now}}},
                new Team { Id = 2,Active = true,Name = "Mile's Team", TeamLeaders = new List<User>{ new User { Id = 10,Active = true,DisplayName = "Mile Grujovski",UserName = "ns\\mile",Role = UserRoleEnum.TeamLeader,Team = null,EmploymentDate = DateTime.Now}}
                }
                
            });
        }
    }
}