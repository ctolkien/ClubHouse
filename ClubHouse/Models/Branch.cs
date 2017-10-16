using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClubHouse.Models
{
    /// <summary>
    /// Branch refers to a GitHub branch. Branches are feature branches associated with Clubhouse Stories.
    /// </summary>
    public class Branch : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// A true/false boolean indicating if the Branch has been deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// The IDs of the Branches the Branch has been merged into.
        /// </summary>
        IReadOnlyCollection<int> MergedBranchIds { get; set; } = new Collection<int>();

        /// <summary>
        /// The name of the Branch.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Branch is persistent; e.g. master.
        /// </summary>
        public bool Persistent { get; set; }

        //pull request

        /// <summary>
        /// The ID of the Repository that contains the Branch.
        /// </summary>
        public int RepositoryId { get; set; }

        /// <summary>
        /// The URL of the Branch.
        /// </summary>
        public string Url { get; set; }
    }
}
