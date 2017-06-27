using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    public class StoryLink : ClubHouseModel<int>
    {
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        public int SubjectId { get; set; }
        [HideFromCreate, HideFromUpdate]
        public DateTime UpdatedAt { get; set; }
        public StoryLinkVerb Verb { get; set; }
        public int ObjectId { get; set; }
    }

    public enum StoryLinkVerb
    {
        Blocks,
        Duplicates,
        RelatesTo
    }
}
