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
        /// <summary>
        /// The user's settings.
        /// </summary>
        public Settings Settings { get; private set; }
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
        public void CreateChallenge(params string[] args)
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
        /// <param name="invite">An invitation they want to accept.</param>
        /// <returns>Returns false if the user attempt to accept someone elses invite.</returns>
        public bool AcceptInvite(Invite invite)
        {
            if (invite.recipient != this)
                return false;

            throw new NotImplementedException();
        }
        /// <summary>
        /// Decline a challenge invitation.
        /// </summary>
        /// <param name="invite">An invitation they want to decline.</param>
        /// <returns>Returns false if the user attempt to decline someone elses invite.</returns>
        public bool DeclineInvite(Invite invite)
        {
            if (invite.recipient != this)
                return false;

            throw new NotImplementedException();
        }
        /// <summary>
        /// Get the user's challenge invites.
        /// </summary>
        /// <returns>Returns the user's pending invites.</returns>
        public IEnumerable<Invite> GetInvites()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get's the available public challenges.
        /// </summary>
        /// <returns>Returns a list of publicly available challenges</returns>
        public IEnumerable<Challenge> GetPublicChallenges()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get's the user's personal challenges.
        /// </summary>
        /// <returns>Returns the challenges the user is participating in.</returns>
        public IEnumerable<Challenge> GetPrivateChallenge()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
