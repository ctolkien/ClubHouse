using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Comment : ClubHouseModel<int>
    {
        public string AuthorId { get; set; }
        [HideFromCreate, HideFromUpdate]
        public DateTime CreatedAt { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Text { get; set; }
        public bool Deleted { get; set; }
        public IReadOnlyList<Comment> Comments { get; set; }
    }
}