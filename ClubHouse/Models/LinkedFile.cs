namespace ClubHouse.Models
{
    /// <summary>
    /// Linked files are stored on a third-party website and linked to one or more <see cref="Story">Stories</see>.
    /// Clubhouse currently supports linking files from Google Drive, Dropbox, Box, and by URL.
    /// See all <seealso cref="LinkedFileType"/>
    /// </summary>
    public class LinkedFile : File
    {
        /// <summary>
        /// The integration type (e.g. google, dropbox, box).
        /// </summary>
        public LinkedFileType Type { get; set; }
    }

    public enum LinkedFileType
    {
        Google,
        Url,
        Dropbox,
        Box,
        Onedrive
    }
}
