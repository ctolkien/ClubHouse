using ClubHouse.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// An Epic is a collection of stories that together might make up a release, a milestone, or some other large initiative that your organization is working on.
    /// </summary>
    public class Epic : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// True/false boolean that indicates whether the Epic is archived or not.
        /// </summary>
        [HideFromCreate]
        public bool Archived { get; set; }

        /// <summary>
        /// A nested array of threaded comments.
        /// </summary>
        [HideFromUpdate]
        public IReadOnlyList<ThreadedComment> Comments { get; set; }

        /// <summary>
        /// A true/false boolean indicating if the <see cref="Epic"/> has been completed.
        /// </summary>
        public bool Completed { get; set; }

        /// <summary>
        /// The time/date the <see cref="Epic"/> was completed.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
        /// <summary>
        /// A manual override for the time/date the <see cref="Epic"/> was completed.
        /// </summary>
        public DateTime? CompletedAtOverride { get; set; }

        /// <summary>
        /// The <see cref="Epic"/> deadline.
        /// </summary>
        public DateTime? Deadline { get; set; }
        /// <summary>
        /// The <see cref="Epic"/> description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the <see cref="Epic"/> has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// An array of UUIDs for any Members you want to add as Followers on this Epic.
        /// </summary>
        public ICollection<string> FollowerIds { get; set; } = new Collection<string>();

        /// <summary>
        /// An array of Labels attached to the Epic.
        /// </summary>
        public ICollection<Label> Labels { get; set; } = new Collection<Label>();

        /// <summary>
        /// The ID of the <see cref="Milestone"/> this <see cref="Epic"/> is related to.
        /// </summary>
        public int? MilestoneId { get; set; }

        /// <summary>
        /// An array of UUIDs for any members you want to add as Owners on this new Epic.
        /// </summary>
        public ICollection<string> OwnerIds { get; set; } = new Collection<string>();


        /// <summary>
        /// The name of the <see cref="Epic"/>.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Epic’s relative position in the Epic workflow state.
        /// </summary>
        [HideFromUpdate, HideFromCreate]
        public int Position { get; set; }

        /// <summary>
        /// The IDs of Projects related to this Epic.
        /// </summary>
        public ICollection<int> ProjectIds { get; set; } = new Collection<int>();

        /// <summary>
        /// A true/false boolean indicating if the Epic has been started.
        /// </summary>
        public bool Started { get; set; }

        /// <summary>
        /// The time/date the Epic was started.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// A manual override for the time/date the Epic was started.
        /// </summary>
        public DateTime? StartedAtOverride { get; set; }

        /// <summary>
        /// The workflow state that the Epic is in.
        /// </summary>
        public EpicState State { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public EpicStatistics Statistics { get; set; }

    }

    /// <summary>
    /// Update Epic can be used to update numerous fields in the Epic.
    /// The only required parameter is Epic ID, which can be found in the Clubhouse UI.
    /// </summary>
    public class EpicUpdate : Epic
    {
        /// <summary>
        /// The ID of the Epic we want to move this Epic after.
        /// </summary>
        public int? AfterId { get; set; }

        /// <summary>
        /// The ID of the Epic we want to move this Epic
        /// </summary>
        public int? BeforeId { get; set; }
    }

    public enum EpicState
    {
        ToDo,
        InProgress,
        Done
    }
    //TODO - clean this up
    public class EpicStatistics
    {
        /// <summary>
        /// The date of the last update of a <see cref="Story"/> in this <see cref="Epic"/>.
        /// </summary>
        public DateTime? LastStoryUpdate { get; set; }

        [JsonProperty(PropertyName = "num_epics")]
        public int Epics { get; set; }

        [JsonProperty(PropertyName = "num_points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "num_points_done")]
        public int PointsDone { get; set; }

        [JsonProperty(PropertyName = "num_points_started")]
        public int PointsStarted { get; set; }

        [JsonProperty(PropertyName = "num_points_unstarted")]
        public int PointsUnstarted { get; set; }

        [JsonProperty(PropertyName = "num_stories_done")]
        public int StoriesDone { get; set; }

        [JsonProperty(PropertyName = "num_stories_started")]
        public int StoriesStarted { get; set; }

        [JsonProperty(PropertyName = "num_stories_unestimated")]
        public int StoriesUnestimated { get; set; }

        [JsonProperty(PropertyName = "num_stories_unstarted")]
        public int StoriesUnstarted { get; set; }

    }
}