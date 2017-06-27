using ClubHouse.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse File
    /// </summary>
    public class File : ClubHouseModel<int>
    {
        public string UploaderId { get; set; }
        public string Name { get; set; }
        public string ThumbnailUrl { get; set; }
        public ICollection<string> MentionIds { get; set; } = new Collection<string>();
        public string Description { get; set; }
        [HideFromUpdate, HideFromCreate]
        public long Size { get; set; }
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        public ICollection<int> StoryIds { get; set; } = new Collection<int>();
        public string ContentType { get; set; }
        public string Filename { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
    }
}
