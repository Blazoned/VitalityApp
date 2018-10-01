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
        /// A private container to keep track of the owner upon request.
        /// </summary>
        private Owner _owner;

        /// <summary>
        /// Gets the challenge id.
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Gets the name of the challenge.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Gets the date and time at which the challenge starts.
        /// </summary>
        public DateTime StartDate { get; private set; }
        /// <summary>
        /// Gets the description of this challenge.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Gets scorepoints that can be gained by a user upon completing the challenge.
        /// </summary>
        public int Score { get; private set; }
        /// <summary>
        /// Gets the location at which the challenge is set to occur.
        /// </summary>
        public string Location { get; private set; }
        /// <summary>
        /// Gets whether the challenge is public or private.
        /// </summary>
        public bool IsPrivate { get; private set; }
        /// <summary>
        /// Gets the time limit which determines how long the challenge will stay active from its starting date.
        /// </summary>
        public int TimeLimit { get; private set; }
        /// <summary>
        /// Determines if the challenge is be repeated and how frequently.
        /// </summary>
        public ERepeat Repeat { get; private set; }
        /// <summary>
        /// Gets a list of all the participants that partake in the challenge.
        /// </summary>
        public List<Participant> Participants { get; private set; }
        /// <summary>
        /// Gets the owner amongst the participants.
        /// </summary>
        public Owner Owner
        {
            get
            {
                if (_owner == null)
                {
                    foreach (Participant participant in Participants)
                    {
                        if (participant.GetType() == typeof(Owner))
                            _owner = (Owner)participant;
                    }
                }

                return _owner;
            }
        }
        #endregion

        #region Constructor
        public Challenge() { }
        #endregion

        #region Functions
        /// <summary>
        /// Remove the given participant from the challenge.
        /// </summary>
        /// <param name="participantToRemove">The participant to remove from the challenge.</param>
        /// <returns>Returns true if the participant was succesfully removed.</returns>
        public bool RemoveParticipant(Participant participantToRemove)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
