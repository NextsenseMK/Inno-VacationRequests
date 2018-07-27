using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class EmployeeOverlapPolicy
    {
        private int _id;
        private string _user1;
        private string _user2;
        private bool _active;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string User1
        {
            get { return _user1; }
            set { _user1 = value; }
        }

        public virtual string User2
        {
            get { return _user2; }
            set { _user2 = value; }
        }

        public virtual bool Active
        {
            get { return _active; }
            set { _active = value; }
        }


    }
}
