namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse <see cref="File"/> which is hosted on a 3rd party service.
    /// See all <seealso cref="LinkedFileType"/>
    /// </summary>
    public class LinkedFile : File
    {
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
