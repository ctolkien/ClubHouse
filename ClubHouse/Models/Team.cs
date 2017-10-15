using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClubHouse.Models
{
    /// <summary>
    /// Group of Projects with the same Workflow.
    /// </summary>
    public class Team : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The description of the Team.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of the Team.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A number representing the position of the Team in relation to every other Team within the Organization.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// An array of IDs of projects within the Team.
        /// </summary>
        public ICollection<int> ProjectIds { get; set; } = new Collection<int>();

        /// <summary>
        /// Details of the workflow associated with the Team.
        /// </summary>
        public Workflow Workflow { get; set; }
    }
}
