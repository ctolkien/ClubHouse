using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    public class StoryLink : ClubHouseModel<int>
    {
        [HideFromUpdate, HideFromCreate]
        public DateTime CreatedAt { get; set; }
        public int SubjectId { get; set; }
        [HideFromCreate]
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
