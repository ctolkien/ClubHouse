using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Story : ClubHouseModel<int>
    {
        public IList<string> FollowerIds { get; set; }
        public int Position { get; set; }
        public IList<string> OwnerIds { get; set; }
        public IList<int> LinkedFileIds { get; set; }
        public IList<Comment> Comments { get; set; }
        public int Estimate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Story_type { get; set; }
        public IList<int> FileIds { get; set; }
        public IList<StoryLink> StoryLinks { get; set; }
        public IList<Label> Labels { get; set; }
        public int ProjectId { get; set; }
        public int EpicId { get; set; }
        public IList<StoryTask> Tasks { get; set; }
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
