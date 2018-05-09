using Newtonsoft.Json;

namespace ClubHouse.Models
{
    /// <summary>
    /// A group of calculated values for a <see cref="Label"/>.
    /// </summary>
    public class LabelStatistics
    {
        /// <summary>
        /// The total number of Epics with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_epics")]
        public int Epics { get; set; }

        /// <summary>
        /// The total number of completed points with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_points_completed")]
        public int PointsCompleted { get; set; }

        /// <summary>
        /// The total number of in-progress points with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_points_in_progress")]
        public int PointsInProgress { get; set; }

        /// <summary>
        /// The total number of points with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_points_total")]
        public int PointsTotal { get; set; }

        /// <summary>
        /// The total number of completed Stories with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_stories_completed")]
        public int StoriesCompleted { get; set; }

        /// <summary>
        /// The total number of in-progress Stories with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_stories_in_progress")]
        public int StoriesInProgress { get; set; }

        /// <summary>
        /// The total number of Stories with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_stories_total")]
        public int StoriesTotal { get; set; }

        /// <summary>
        /// The total number of Stories with no point estimate with this Label.
        /// </summary>
        [JsonProperty(PropertyName = "num_stories_unestimated")]
        public int StoriesUnestimated { get; set; }
    }
}
