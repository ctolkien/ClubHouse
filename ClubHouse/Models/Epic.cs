using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Epic : ClubHouseModel<int>
    {
        public IList<string> FollowerIds { get; set; }
        public IList<string> OwnerIds { get; set; }
        public DateTime Deadline { get; set; }
        [HideFromUpdate]
        public int Position { get; set; }
        public string Name { get; set; }

        [HideFromUpdate]
        public IList<Comment> Comments { get; set; }
        public bool Archived { get; set; }
        public string Description { get; set; }
        public EpicState State { get; set; }
        [HideFromUpdate]
        public DateTime CreatedAt { get; set; }
        [HideFromUpdate]
        public DateTime UpdatedAt { get; set; }
    }

    internal class EpicUpdate : Epic
    {
        public int? AfterId { get; set; }
        public int? BeforeId { get; set; }
    }

    public enum EpicState
    {
        [JsonProperty("to do")]
        ToDo,
        InProgress,
        Done
    }
}