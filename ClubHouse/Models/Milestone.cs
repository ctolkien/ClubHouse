using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Milestone is a collection of Epics that represent a release or some other large initiative that your organization is working on.
    /// </summary>
    public class Milestone : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// An array of Categories attached to the Milestone.
        /// </summary>
        public ICollection<Category> Categories { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Milestone has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The time/date the Milestone was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// A manual override for the time/date the Milestone was completed.
        /// </summary>
        public DateTime? CompletedAtOverride { get; set; }

        /// <summary>
        /// The Milestone’s description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of the Milestone.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A number representing the position of the Milestone in relation to every other Milestone within the Organization.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Milestone has been started.
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// The time/date the Milestone was started.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// A manual override for the time/date the Milestone was started.
        /// </summary>
        public DateTime? StartedAtOverride { get; set; }

        /// <summary>
        /// The workflow state that the Milestone is in.
        /// </summary>
        public string State { get; set; }
    }
}
