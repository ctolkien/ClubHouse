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

        public enum StoryLinkVerb
        {
            Blocks,
            Duplicates,
            RelatesTo
        }
    }

    /// <summary>
    /// The type of Story Link. The string can be subject or object.
    /// </summary>
    public class TypedStoryLink : StoryLink
    {
        /// <summary>
        /// This indicates whether the Story is the subject or object in the Story Link.
        /// </summary>
        public TypedStoryLinkType Type { get; set; }

        public enum TypedStoryLinkType
        {
            Subject,
            Object
        }
    }
}
