using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Story : ClubHouseModel<int>
    {
        public IList<string> FollowerIds { get; set; }
        public int Position { get; set; }
        public IList<string> OwnerIds { get; set; }
        public IReadOnlyList<Comment> Comments { get; set; }
        public int Estimate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string StoryType { get; set; }
        public IList<int> FileIds { get; set; }
        public IList<int> LinkedFileIds { get; set; }
        public IReadOnlyList<StoryLink> StoryLinks { get; set; }
        public IReadOnlyList<Label> Labels { get; set; }
        public int ProjectId { get; set; }
        public int EpicId { get; set; }
        public IReadOnlyList<StoryTask> Tasks { get; set; }
        public DateTime Deadline { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
        public string RequestedById { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int WorkflowStateId { get; set; }
    }

    public class StoryTask : ClubHouseModel<int>
    {
        public int StoryId { get; set; }
        public int Position { get; set; }
        public IList<string> OwnerIds { get; set; }
        public IList<string> MentionIds { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public bool Complete { get; set; }
    }

}
