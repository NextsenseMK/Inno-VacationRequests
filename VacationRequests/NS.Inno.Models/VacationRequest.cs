using NS.Inno.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class VacationRequest
    {
        private int _id;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private int _days;
        private StatusVacationRequestEnum _status;
        private string _description;
        private int _year;
        private User _user;
        private DateTime _createdOn;
        private DateTime _modifiedOn;
        private User _modifiedBy;
        private User _createdBy;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual DateTime DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }
        public virtual DateTime DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }
        public virtual StatusVacationRequestEnum Status
        {
            get { return _status;}
            set { _status = value; }
}
        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public virtual int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public virtual User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public virtual DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }
        public virtual DateTime ModifiedOn
        {
            get { return _modifiedOn; }
            set { _modifiedOn = value; }
        }
        public virtual User ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }
        public virtual User CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

    }
}
