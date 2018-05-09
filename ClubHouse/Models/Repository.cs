using Newtonsoft.Json;

namespace ClubHouse.Models
{
    /// <summary>
    /// Repository refers to a GitHub repository.
    /// </summary>
    public class Repository : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The GitHub unique identifier for the Repository.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The full name of the GitHub repository.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The shorthand name of the GitHub repository.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of Repository. Currently this can only be “github”.
        /// </summary>
        public RepositoryType Type { get; set; }

        /// <summary>
        /// The URL of the Repository.
        /// </summary>
        public string Url { get; set; }
    }

    public enum RepositoryType
    {
        [JsonProperty(PropertyName = "github")] //'GitHub' casing would get changed to 'git_hub'
        GitHub
    }
}
