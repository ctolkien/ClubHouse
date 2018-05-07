using ClubHouse.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Comment is any note added within the Comment field of a Story.
    /// </summary>
    public class Comment : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The unique ID of the Member who is the Comment’s author.
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Comment has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The unique IDs of the Member who are mentioned in the Comment.
        /// </summary>
        public IReadOnlyCollection<string> MentionIds { get; set; } = new Collection<string>();

        /// <summary>
        /// The Comments numerical position in the list from oldest to newest.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// The ID of the Story on which the Comment appears.
        /// </summary>
        public int StoryId { get; set; }

        /// <summary>
        /// The text of the Comment.
        /// </summary>
        public string Text { get; set; }
    }
}