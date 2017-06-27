using ClubHouse.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse story
    /// </summary>
    public class Story : ClubHouseModel<int>
    {
        public ICollection<string> FollowerIds { get; set; } = new Collection<string>();
        [HideFromCreate]
        public long Position { get; set; }
        public ICollection<string> OwnerIds { get; set; } = new Collection<string>();
        public ICollection<Comment> Comments { get; set; } = new Collection<Comment>();
        public int? Estimate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public StoryType StoryType { get; set; }
        public ICollection<int> FileIds { get; set; } = new Collection<int>();
        public ICollection<int> LinkedFileIds { get; set; } = new Collection<int>();
        public ICollection<StoryLink> StoryLinks { get; set; } = new Collection<StoryLink>();
        public ICollection<Label> Labels { get; set; } = new Collection<Label>();
        public int ProjectId { get; set; }
        public int? EpicId { get; set; }
        public ICollection<StoryTask> Tasks { get; set; } = new Collection<StoryTask>();
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
        public ICollection<string> OwnerIds { get; set; }
        public ICollection<string> MentionIds { get; set; }
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
