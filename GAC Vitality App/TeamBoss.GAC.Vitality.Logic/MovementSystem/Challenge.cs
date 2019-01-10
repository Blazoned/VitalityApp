using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Challenge
    {
        public bool IsPrivate
        {
            get;
            private set;
        }
        public int Goal
        {
            get;
            private set;
        }
        public int ID
        {
            get;
            private set;
        }
        public int Progress
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }
        public string GoalUnitName
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public string Location
        {
            get;
            private set;
        }

        public Challenge(bool _isPrivate, int _goal, int _id, int _progress, string _description, string _goalUnitName, string _name, string _location)
        {
            IsPrivate = _isPrivate;
            Goal = _goal;
            ID = _id;
            Progress = _progress;
            Description = _description;
            GoalUnitName = _goalUnitName;
            Name = _name;
            Location = _location;
        }
    }
}
