using System;
using System.Collections.Generic;
using System.Text;

namespace NS.Inno.Models
{
    public class Team
    {
        private int _id;
        private string _name;
        private List<string> _teamLeaders;
        private bool _active;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual List<string> TeamLeaders
        {
            get { return _teamLeaders; }
            set { _teamLeaders = value; }
        }

        public virtual bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
    }
}
