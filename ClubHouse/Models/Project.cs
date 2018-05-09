using ClubHouse.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// Projects typically map to teams (such as Frontend, Backend, Mobile, Devops, etc) but can represent any open-ended product, component, or initiative.
    /// </summary>
    public class Project : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The Project abbreviation used in Story summaries. Should be kept to 3 characters at most.
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// True/false boolean indicating whether the Project is in an Archived state.
        /// </summary>
        [HideFromCreate]
        public bool Archived { get; set; }

        /// <summary>
        /// The color associated with the Project in the Clubhouse member interface.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The number of days before the thermometer appears in the Story summary.
        /// </summary>
        public int DaysToThermometer { get; set; }

        /// <summary>
        /// The description of the Project.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Project has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// An array of UUIDs for any <see cref="Member"/> listed as Followers.
        /// </summary>
        public ICollection<string> FollowerIds { get; set; } = new Collection<string>();

        /// <summary>
        /// The number of weeks per iteration in this Project.
        /// </summary>
        public int IterationLength { get; set; }

        /// <summary>
        /// The name of the Project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Configuration to enable or disable thermometers in the Story summary.
        /// </summary>
        public bool ShowThermometer { get; set; }

        /// <summary>
        /// The date at which the Project was started.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// A group of calculated values for this Project.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public ProjectStatistics Statistics { get; set; }

        /// <summary>
        /// The ID of the <see cref="Team"/> the project belongs to.
        /// </summary>
        public int TeamId { get; set; }
    }

    /// <summary>
    /// A group of calculated values for an Project.
    /// </summary>
    public class ProjectStatistics
    {
        /// <summary>
        /// The total number of points in this <see cref="Project"/>.
        /// </summary>
        [JsonProperty(PropertyName = "num_points")]
        public int Points { get; set; }

        /// <summary>
        /// The total number of stories in this <see cref="Project"/>.
        /// </summary>
        [JsonProperty(PropertyName = "num_stories")]
        public int Stories { get; set; }
    }
}