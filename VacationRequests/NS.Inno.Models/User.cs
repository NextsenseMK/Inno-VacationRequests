using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class User
    {
        private int _id;
        private string _username;
        private string _displayname;
        private bool _active;
        private string _role;
        private Team _team;
        private DateTime _employmentdate;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public virtual string DisplayName
        {
            get { return _displayname; }
            set { _displayname = value; }
        }
        public virtual bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public virtual string Role
        {
            get { return _role;}
            set { _role = value; }
        }
        public virtual Team Team
        {
            get { return _team; }
            set { _team = value; }
        }
        public virtual DateTime EmploymentDate
        {
            get { return _employmentdate; }
            set { _employmentdate = value; }
        }


    }
}
