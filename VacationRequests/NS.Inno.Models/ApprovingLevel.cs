using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class ApprovingLevel
    {
        private int _id;
        private VacationRequest _vacationRequest;
        private int _level;
        private DateTime _createdOn;
        private DateTime _actionOn;
        private string _status;
        private User _createdBy;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value;  }
        }

        public virtual VacationRequest VacationRequest
        {
            get { return _vacationRequest; }
            set { _vacationRequest = value; }
        }

        public virtual int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public virtual DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        public virtual DateTime ActionOn
        {
            get { return _actionOn; }
            set { _actionOn = value; }
        }

        public virtual string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public virtual User CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

    }
}
