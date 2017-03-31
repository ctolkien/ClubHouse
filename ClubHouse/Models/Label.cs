using System;

namespace ClubHouse.Models
{
    public class Label : ClubHouseModel<int>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

    }

    public class LabelWithCounts : Label
    {
        public int NumStoriesInProgress { get; set; }
        public int NumStoriesTotal { get; set; }
        public int NumStoriesCompleted { get; set; }
    }

}
