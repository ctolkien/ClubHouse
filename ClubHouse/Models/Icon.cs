namespace ClubHouse.Models
{
    /// <summary>
    /// Icons are used to attach images to Organizations, Members, and Loading screens in the Clubhouse web application.
    /// </summary>
    public class Icon : UpdatableClubHouseModel<string>
    {
        /// <summary>
        /// The URL of the Icon.
        /// </summary>
        public string Url { get; set; }
    }
}
