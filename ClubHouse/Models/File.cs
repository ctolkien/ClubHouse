using ClubHouse.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A File is any document uploaded to your Clubhouse.
    /// Files attached from a third-party service can be accessed using the <see cref="LinkedFile"/> endpoint.
    /// </summary>
    public class File : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// Free form string corresponding to a text or image file.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// The description of the <see cref="File"/>.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This field can be set to another unique ID.
        /// In the case that the File has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The name assigned to the file in Clubhouse upon upload.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        ///The unique IDs of the <see cref="Member">Members</see> who are mentioned in the file description.
        /// </summary>
        public IReadOnlyCollection<string> MentionIds { get; set; } = new Collection<string>();

        /// <summary>
        /// The optional User-specified name of the file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The size of the file.
        /// </summary>
        [HideFromUpdate, HideFromCreate]
        public long Size { get; set; }

        /// <summary>
        /// The unique IDs of the <see cref="Story">Stories</see> associated with this file.
        /// </summary>
        public IReadOnlyCollection<int> StoryIds { get; set; } = new Collection<int>();

        /// <summary>
        /// The url where the thumbnail of the file can be found in Clubhouse.
        /// </summary>
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// The unique ID of the <see cref="Member"/> who uploaded the file.
        /// </summary>
        public string UploaderId { get; set; }

        /// <summary>
        /// The URL for the file.
        /// </summary>
        public string Url { get; set; }
    }
}
