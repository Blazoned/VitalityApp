using System.Collections.Generic;

using TeamBoss.GAC.Vitality.Logic;

namespace TeamBoss.GAC.Vitality.AspCore.ViewModels.MovementViewModels
{
    public class ChallengeInfoViewModel
    {
        public Challenge SelectedChallenge
        {
            get;
            set;
        }
        public float PercentageDone
        {
            get;
            set;
        }
        public float PercentageToGo
        {
            get;
            set;
        }
    }
}