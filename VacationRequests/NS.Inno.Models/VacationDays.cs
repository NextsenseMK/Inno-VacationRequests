using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class VacationDays
    {
        private int _id;
        private User _user;
        private int _usedDays;
        private int _totalDays;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public virtual int DisplayName
        {
            get { return _usedDays; }
            set { _usedDays = value; }
        }
        public virtual int TotalDays
        {
            get { return _totalDays; }
            set { _totalDays = value; }
        }

    }
}
