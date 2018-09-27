using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class User
    {
        #region Fields
        /// <summary>
        /// Gets the username.
        /// </summary>
        public string Username { get; private set; }
        /// <summary>
        /// Gets the user's email.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Gets the user's total score.
        /// </summary>
        public int TotalScore { get; private set; }
        #endregion

        #region Constructors
        public User()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Create a brand new challenge.
        /// </summary>
        public void CreateChallenge()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Join an existing challenge.
        /// </summary>
        /// <param name="challenge">The challenge which they wish to join.</param>
        public void JoinChallenge(ref Challenge challenge)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Accept a challenge invitation.
        /// </summary>
        /// <param name="invite">An invitation they received.</param>
        public void AcceptInvite(Invite invite)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
