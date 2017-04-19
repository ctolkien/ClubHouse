using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse story
    /// </summary>
    public class Story : ClubHouseModel<int>
    {
        public IList<string> FollowerIds { get; set; }
        [HideFromCreate]
        public long Position { get; set; }
        public IList<string> OwnerIds { get; set; }
        public IList<Comment> Comments { get; set; }
        public int? Estimate { get; set; }
        [HideFromCreate]
        public DateTime CreatedAt { get; set; }
        public StoryType StoryType { get; set; }
        public IList<int> FileIds { get; set; }
        public IList<int> LinkedFileIds { get; set; }
        public IList<StoryLink> StoryLinks { get; set; }
        public IList<Label> Labels { get; set; }
        public int ProjectId { get; set; }
        public int? EpicId { get; set; }
        public IList<StoryTask> Tasks { get; set; }
        public DateTime? Deadline { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [HideFromCreate]
        public bool Archived { get; set; }
        public string RequestedById { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public int? WorkflowStateId { get; set; }

    }
    public enum StoryType
    {
        Feature,
        Chore,
        Bug
    }

    public class StoryTask : ClubHouseModel<int>
    {
        [HideFromCreate, HideFromUpdate]
        public int StoryId { get; set; }
        [HideFromCreate]
        public int Position { get; set; }
        public IList<string> OwnerIds { get; set; }
        public IList<string> MentionIds { get; set; }
        public string Description { get; set; }
        [HideFromCreate]
        public DateTime CreatedAt { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        [HideFromCreate]
        public DateTime CompletedAt { get; set; }
        public bool Complete { get; set; }
    }
}
