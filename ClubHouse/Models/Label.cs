using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse Label
    /// </summary>
    public class Label : ClubHouseModel<int>
    {
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

    }

    /// <summary>
    /// A Clubhouse Label including details about it's usage.
    /// </summary>
    public class LabelWithCounts : Label
    {
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesInProgress { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesTotal { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStoriesCompleted { get; set; }
    }
}
