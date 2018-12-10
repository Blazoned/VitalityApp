using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DataInterfaces
{
    public class ReactionStruct
    {
        public string Description { get; private set; }
        public string Username { get; private set; }

        public ReactionStruct(string description, string username)
        {
            Description = description;
            Username = username;
        }
    }
}
