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
        public string Username { get; private set; }
        public string Email { get; private set; }
        public int TotalScore { get; private set; }
        #endregion

        #region Constructors
        public User()
        {

        }
        #endregion

        #region Methods
        public Challenge CreateChallenge()
        {
            throw new NotImplementedException();
        }
        public Challenge JoinChallenge()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
