using System.Collections.Generic;

using TeamBoss.GAC.Vitality.Logic;

namespace TeamBoss.GAC.Vitality.AspCore.ViewModels.MovementViewModels
{
    public class IndexViewModel
    {
        public List<Challenge> PublicChallenges
        {
            get;
            set;
        }
        public List<Challenge> PrivateChallenges
        {
            get;
            set;
        }
    }
}