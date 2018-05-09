using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// Commit refers to a GitHub commit and all associated details.
    /// </summary>
    public class Commit : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The email address of the GitHub user that authored the Commit.
        /// </summary>
        public string AuthorEmail { get; set; }

        /// <summary>
        /// The ID of the Member that authored the Commit, if known.
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// The Identity of the GitHub user that authored the Commit.
        /// </summary>
        public Identity AuthorIdentity { get; set; }

        /// <summary>
        /// The Commit hash.
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// The IDs of the Branches the Commit has been merged into.
        /// </summary>
        public IReadOnlyCollection<int> MergedBranchIds { get; set; } = new Collection<int>();

        /// <summary>
        /// The Commit message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The ID of the Repository that contains the Commit.
        /// </summary>
        public int RepositoryId { get; set; }

        /// <summary>
        /// The time/date the Commit was pushed.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The URL of the Commit.
        /// </summary>
        public string Url { get; set; }
    }
}
