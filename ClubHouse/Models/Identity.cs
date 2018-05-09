namespace ClubHouse.Models
{
    /// <summary>
    /// Identity is your GitHub login. Clubhouse uses Identity to attempt to connect your GitHub actions with your Clubhouse Stories.
    /// </summary>
    public class Identity
    {
        /// <summary>
        /// This is your login in GitHub.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of Identity; currently only type is github.
        /// </summary>
        public IdentityType? Type { get; set; }
    }


    public enum IdentityType
    {
        GitHub
    }
}
