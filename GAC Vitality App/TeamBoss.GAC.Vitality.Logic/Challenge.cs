using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Challenge
    {
        #region Fields
        /// <summary>
        /// The name of the challenge which defines its type.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The date and time at which the challenge was started.
        /// </summary>
        public DateTime StartDate { get; private set; }
        /// <summary>
        /// A description of the challenge to further clarify what it entails.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// The amount of score that can be gained by a user upon completing the challenge.
        /// </summary>
        public int Score { get; private set; }
        /// <summary>
        /// The location at which the challenge is set to occur.
        /// </summary>
        public string Location { get; private set; }
        /// <summary>
        /// Is the challenge private?
        /// </summary>
        public bool IsPrivate { get; private set; }
        /// <summary>
        /// The time limit which determines how long a challenge takes from its starting date.
        /// </summary>
        public int TimeLimit { get; private set; }
        /// <summary>
        /// Determines if the challenge is be repeated and how frequently.
        /// </summary>
        public ERepeat Repeat { get; private set; }
        /// <summary>
        /// A list of all the participants that partake in the challenge.
        /// </summary>
        public List<Participant> ParticipantList { get; private set; }
        #endregion

        #region Constructor
        public Challenge() { }
        #endregion

        #region Methods
        /// <summary>
        /// Makes it possible for a participant to clear a challenge.
        /// </summary>
        /// <param name="participant">The participant who has cleared the challenge.</param>
        /// <returns></returns>
        public int ClearChallenge(Participant participant)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Allows the removal of the given participant from the challenge.
        /// </summary>
        /// <param name="participantToRemove">The participant to remove from the challenge.</param>
        /// <returns></returns>
        public bool RemoveParticipant(Participant participantToRemove)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns a reference to the owner of the challenge.
        /// </summary>
        /// <returns></returns>
        public Owner GetOwner()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
