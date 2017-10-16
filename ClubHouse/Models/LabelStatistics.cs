using Newtonsoft.Json;

namespace ClubHouse.Models
{
    public class LabelStatistics
    {
        [JsonProperty(PropertyName = "num_epics")]
        public int Epics { get; set; }
        [JsonProperty(PropertyName = "num_points_completed")]
        public int PointsCompleted { get; set; }
        [JsonProperty(PropertyName = "num_points_in_progress")]
        public int PointsInProgress { get; set; }
        [JsonProperty(PropertyName = "num_points_total")]
        public int PointsTotal { get; set; }
        [JsonProperty(PropertyName = "num_stories_completed")]
        public int StoriesCompleted { get; set; }
        [JsonProperty(PropertyName = "num_stories_in_progress")]
        public int StoriesInProgress { get; set; }
        [JsonProperty(PropertyName = "num_stories_total")]
        public int StoriesTotal { get; set; }
        [JsonProperty(PropertyName = "num_stories_unestimated")]
        public int StoriesUnestimated { get; set; }

    }
}
