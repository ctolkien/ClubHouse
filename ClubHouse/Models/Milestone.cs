using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Milestone : UpdatableClubHouseModel<int>
    {
        public ICollection<Category> Categories { get; set; }
        public bool Completed { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? CompletedAtOverride { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? StartedAtOverride { get; set; }
        public string State { get; set; }
    }
}
