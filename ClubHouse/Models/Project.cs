using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Project : ClubHouseModel<int>
    {
        public int NumPoints { get; set; }
        public IList<string> FollowerIds { get; set; }
        public string Name { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Color { get; set; }
        public int NumStories { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Abbreviation { get; set; }
    }
}