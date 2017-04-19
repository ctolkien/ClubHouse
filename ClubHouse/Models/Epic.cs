using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse Epic
    /// </summary>
    public class Epic : ClubHouseModel<int>
    {
        public IList<string> FollowerIds { get; set; }
        public IList<string> OwnerIds { get; set; }
        public DateTime? Deadline { get; set; }
        [HideFromUpdate, HideFromCreate]
        public int Position { get; set; }
        public string Name { get; set; }

        [HideFromUpdate]
        public IReadOnlyList<Comment> Comments { get; set; }
        [HideFromCreate]
        public bool Archived { get; set; }
        public string Description { get; set; }
        public EpicState State { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime CreatedAt { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
    }

    public class EpicUpdate : Epic
    {
        public int? AfterId { get; set; }
        public int? BeforeId { get; set; }
    }

    public enum EpicState
    {
        ToDo,
        InProgress,
        Done
    }
}