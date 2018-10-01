using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class ChallengeManager
    {
        #region Fields
        #region Variables
        /// <summary>
        /// Contains the user in charge of the manager.
        /// </summary>
        private User _user;
        /// <summary>
        /// Contains the user's invites.
        /// </summary>
        private List<Invite> _invites;
        /// <summary>
        /// Contains the personal challenges.
        /// </summary>
        private List<Challenge> _personalChallenges;
        /// <summary>
        /// Contains the public challenges.
        /// </summary>
        private List<Challenge> _publicChallenges;
        #endregion


        #region Properties
        /// <summary>
        /// Gets the invites of the user.
        /// </summary>
        public List<Invite> Invites
        {
            get
            {
                if (_invites == null)
                {
                    _invites = GetInvites();
                }

                return _invites;
            }
        }
        /// <summary>
        /// Gets the personal challenges of the user.
        /// </summary>
        public List<Challenge> PersonalChallenges
        {
            get
            {
                if (_personalChallenges == null)
                {
                    _personalChallenges = GetPrivateChallenge();
                }

                return _personalChallenges;
            }
        }
        /// <summary>
        /// Gets all publicly available challenges.
        /// </summary>
        public List<Challenge> PublicChallenges
        {
            get
            {
                if (_publicChallenges == null)
                {
                    _publicChallenges = GetPublicChallenges();
                }

                return _publicChallenges;
            }
        }
        #endregion
        #endregion

        #region Constructor
        /// <summary>
        /// Create an instance of the challenge manager.
        /// </summary>
        /// <param name="user">The user connected to this manager.</param>
        public ChallengeManager(User user)
        {
            _user = user;
        }
        #endregion

        #region Functions
        /// <summary>
        /// Clear a challenge for the user.
        /// </summary>
        /// <param name="index">The index of a challenge within the list of personal challenges.</param>
        /// <returns>Returns the scorepoints granted by completing this challenge.</returns>
        public int ClearChallenge(int index)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get the user's challenge invites.
        /// </summary>
        /// <returns>Returns the user's pending invites.</returns>
        private List<Invite> GetInvites()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get's the available public challenges.
        /// </summary>
        /// <returns>Returns a list of publicly available challenges</returns>
        private List<Challenge> GetPublicChallenges()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get's the user's personal challenges.
        /// </summary>
        /// <returns>Returns the challenges the user is participating in.</returns>
        private List<Challenge> GetPrivateChallenge()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
