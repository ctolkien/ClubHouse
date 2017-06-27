using ClubHouse.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse Project
    /// </summary>
    public class Project : ClubHouseModel<int>
    {
        [HideFromUpdate, HideFromCreate]
        public int NumPoints { get; set; }
        public ICollection<string> FollowerIds { get; set; } = new Collection<string>();
        public string Name { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        public string Color { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStories { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Abbreviation { get; set; }
    }
}