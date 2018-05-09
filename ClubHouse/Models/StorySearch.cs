using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// Stories are the standard unit of work in Clubhouse and represent individual features, bugs, and chores.
    /// This is returned from performing a search
    /// </summary>
    public class StorySearch : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The clubhouse application url for the story.
        /// </summary>
        public string AppUrl { get; set; }

        /// <summary>
        /// True if the story has been archived or not.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Story is currently blocked.
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Story is currently a blocker of another story.
        /// </summary>
        public bool Blocker { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Story has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The time/date the Story was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// A manual override for the time/date the Story was completed.
        /// </summary>
        public DateTime? CompletedAtOverride{ get; set; }

        /// <summary>
        /// The due date of the story.
        /// </summary>
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// The description of the story.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The ID of the epic the story belongs to.
        /// </summary>
        public int? EpicId { get; set; }

        /// <summary>
        /// The numeric point estimate of the story. Can also be null, which means unestimated.
        /// </summary>
        public int? Estimate { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Story has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// An array of UUIDs of the followers of this story.
        /// </summary>
        public IReadOnlyCollection<string> FollowerIds { get; set; } = new Collection<string>();

        /// <summary>
        /// An array of labels attached to the story.
        /// </summary>
        public IReadOnlyCollection<Label> Labels { get; set; } = new Collection<Label>();

        /// <summary>
        /// The time/date the Story was last changed workflow-state.
        /// </summary>
        public DateTime? MovedAt { get; set; }

        /// <summary>
        /// The name of the story.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// An array of UUIDs of the owners of this story.
        /// </summary>
        public IReadOnlyCollection<string> OwnerIds { get; set; } = new Collection<string>();

        /// <summary>
        /// A number representing the position of the story in relation to every other story in the current project.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// The ID of the project the story belongs to.
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// The ID of the Member that requested the story.
        /// </summary>
        public string RequestedById { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the Story has been started.
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// The time/date the Story was started.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// A manual override for the time/date the Story was started.
        /// </summary>
        public DateTime? StartedAtOverride { get; set; }

        /// <summary>
        /// An array of story links attached to the story.
        /// </summary>
        public IReadOnlyCollection<TypedStoryLink> StoryLinks { get; set; } = new Collection<TypedStoryLink>();

        /// <summary>
        /// The type of story (feature, bug, chore).
        /// </summary>
        public StoryType StoryType { get; set; }

        /// <summary>
        /// The ID of the workflow state the story is currently in.
        /// </summary>
        public int WorkflowStateId { get; set; }
    }
}
