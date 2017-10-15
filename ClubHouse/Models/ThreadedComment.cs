using System;
using System.Collections.Generic;
using System.Text;

namespace ClubHouse.Models
{
    /// <summary>
    /// Comments associated with <see cref="Models.Epic"/> Discussions.
    /// </summary>
    public class ThreadedComment : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The unique ID of the Member that authored the Comment.
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// A nested array of threaded comments.
        /// </summary>
        public IReadOnlyCollection<ThreadedComment> Comments { get; set; }

        /// <summary>
        /// True/false boolean indicating whether the Comment is deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Comment has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// An array of Member IDs that have been mentioned in this Comment
        /// </summary>
        public IReadOnlyCollection<string> MentionIds { get; set; }

        /// <summary>
        /// The text of the Comment.
        /// </summary>
        public string Text { get; set; }
    }
}
