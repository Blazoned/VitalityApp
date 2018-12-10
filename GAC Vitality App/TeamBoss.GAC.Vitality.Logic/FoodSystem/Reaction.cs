using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DataInterfaces;

namespace TeamBoss.GAC.Vitality.Logic.FoodSystem
{
    class Reaction
    {
        private string username { get; set; }
        private string description { get; set; }

        public Reaction(ReactionStruct reactionStruct)
        {
            username = reactionStruct.Username;
            description = reactionStruct.Description; 
        }
    }
}
