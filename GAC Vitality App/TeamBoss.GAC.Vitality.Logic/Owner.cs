using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Owner : Participant
    {
        #region Fields
        /// <summary>
        /// A list of all the challenges the owner is the owner of.
        /// </summary>
        public List<Challenge> ownerChallengeList { get; private set; }
        #endregion

        #region Constructor
        public Owner() { }
        #endregion

        #region Methods
        /// <summary>
        /// Allows for the invitation of a user to the challenge of the owner by username.
        /// </summary>
        /// <param name="username">The username of the user to invite.</param>
        /// <returns></returns>
        public bool InviteUser(string username)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows for the deletion of a challenge.
        /// </summary>
        /// <param name="challengeToDelete">A reference to the challenge to delete.</param>
        /// <returns></returns>
        public bool DeleteChallenge(Challenge challengeToDelete)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Changes the privacy setting of the given challenge.
        /// </summary>
        /// <param name="challengeToChange">The challenge whose privacy option to change.</param>
        /// <returns></returns>
        public bool ChangePrivacy(ref Challenge challengeToChange)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
