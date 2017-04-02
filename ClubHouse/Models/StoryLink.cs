using System;

namespace ClubHouse.Models
{
    public class StoryLink : ClubHouseModel<int>
    {
        public DateTime CreatedAt { get; set; }
        public int SubjectId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Verb { get; set; }
        public string Type { get; set; }
        public int ObjectId { get; set; }
    }
}
