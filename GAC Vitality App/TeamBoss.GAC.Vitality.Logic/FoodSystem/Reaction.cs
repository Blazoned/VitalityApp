using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Reaction : IReactionLogic
    {
        /*private string username { get; set; }
        private string description { get; set; }

        public Reaction() { }

        public void SetProperties(ReactionStruct reactionStruct)
        {
            username = reactionStruct.Username;
            description = reactionStruct.Description;
        }*/

        public string Username { get; set; }
        public string Message { get; set; }

        public bool SetProperties()
        {
            throw new NotImplementedException();
        }
    }
}
