using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Invite
    {
        #region Fields
        /// <summary>
        /// A reference to the user that has been invited to the challenge.
        /// </summary>
        public User InvitedUser { get; private set; }
        /// <summary>
        /// A reference to the challenge the user has been invited to.
        /// </summary>
        public Challenge Challenge { get; private set; }
        #endregion

        #region Constructor
        public Invite() { }
        #endregion

        #region Methods
        public string GetChallengeName()
        {
            throw new NotImplementedException();
        }
        public Owner GetOwner()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
