using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Task : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// True/false boolean indicating whether the Task has been completed.
        /// </summary>
        public bool Complete { get; set; }

        /// <summary>
        /// The time/date the Task was completed.
        /// </summary>
        [HideFromCreate]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Full text of the Task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Task has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// An array of UUIDs of Members mentioned in this Task.
        /// </summary>
        public IReadOnlyCollection<string> MentionIds { get; set; }

        /// <summary>
        /// An array of UUIDs of the Owners of this Task.
        /// </summary>
        public ICollection<string> OwnerIds { get; set; }

        /// <summary>
        /// The number corresponding to the Task’s position within a list of Tasks on a Story.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// The unique identifier of the parent Story.
        /// </summary>
        public int StoryId { get; set; }
    }
}
