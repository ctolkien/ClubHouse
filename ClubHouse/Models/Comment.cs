using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// A <see cref="Comment"/> on a Clubhouse resource.
    /// Comments can also have child comments.
    /// </summary>
    public class Comment : ClubHouseModel<int>
    {
        public string AuthorId { get; set; }
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Text { get; set; }
        [HideFromCreate]
        public bool Deleted { get; set; }
        /// <summary>
        /// A collection of child comments.
        /// </summary>
        public IReadOnlyCollection<Comment> Comments { get; set; }
    }
}