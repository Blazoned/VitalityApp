using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Participant : User
    {
        #region Fields
        /// <summary>
        /// A list containing all of the challenges the participant is participating in but not the owner of.
        /// </summary>
        public List<Challenge> participantChallengeList { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Allows the participant to leave a challenge.
        /// </summary>
        /// <param name="challengeToLeave">A reference to the challenge to leave.</param>
        /// <returns></returns>
        public bool LeaveChallenge(Challenge challengeToLeave)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows the participant to finish a challenge.
        /// </summary>
        /// <param name="challengeToClear">A reference to the challenge to clear.</param>
        /// <returns></returns>
        public bool ClearChallenge(ref Challenge challengeToClear)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows the participant to share the challenge via social media.
        /// </summary>
        /// <param name="challengeToShare">A reference to the challenge to share.</param>
        /// <returns></returns>
        public bool ShareChallenge(Challenge challengeToShare)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
