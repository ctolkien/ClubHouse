using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Project : ClubHouseModel<int>
    {
        [HideFromUpdate, HideFromCreate]
        public int NumPoints { get; set; }
        public IList<string> FollowerIds { get; set; }
        public string Name { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime CreatedAt { get; set; }
        public string Color { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int NumStories { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Abbreviation { get; set; }
    }
}