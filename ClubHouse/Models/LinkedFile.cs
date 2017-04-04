namespace ClubHouse.Models
{
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
