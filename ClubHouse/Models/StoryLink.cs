using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    /// <summary>
    /// Story links allow you create semantic relationships between two stories.
    /// Relationship types are relates to, blocks / blocked by, and duplicates / is duplicated by.
    /// The format is subject -> link -> object, or for example “story 5 blocks story 6”.
    /// </summary>
    public class StoryLink : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The ID of the object Story.
        /// </summary>
        public int ObjectId { get; set; }

        /// <summary>
        /// The ID of the Subject story.
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// The type of Story Link. This can be “blocks”, “duplicates”, or “relates to”.
        /// </summary>
        public StoryLinkVerb Verb { get; set; }
    }

    public enum StoryLinkVerb
    {
        Blocks,
        Duplicates,
        RelatesTo
    }
}
