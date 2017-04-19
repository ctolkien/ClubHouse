using ClubHouse.Serialization;
using System;
using System.Collections.Generic;

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
        public IList<string> MentionIds { get; set; }
        public string Description { get; set; }
        [HideFromUpdate, HideFromCreate]
        public long Size { get; set; }
        [HideFromUpdate, HideFromCreate]
        public DateTime CreatedAt { get; set; }
        public IList<int> StoryIds { get; set; }
        public string ContentType { get; set; }
        public string Filename { get; set; }
        [HideFromCreate]
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
    }
}
