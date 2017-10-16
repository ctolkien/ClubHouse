namespace ClubHouse.Models
{
    /// <summary>
    /// Corresponds to a GitHub Pull Request attached to a Clubhouse story.
    /// </summary>
    public class PullRequest : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The ID of the branch for the particular pull request.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// True/False boolean indicating whether the GitHub pull request has been closed.
        /// </summary>
        public bool Closed { get; set; }

        /// <summary>
        /// Number of lines added in the pull request, according to GitHub.
        /// </summary>
        public int NumAdded { get; set; }

        /// <summary>
        /// The number of commits on the pull request.
        /// </summary>
        public int NumCommits { get; set; }

        /// <summary>
        /// Number of lines modified in the pull request, according to GitHub.
        /// </summary>
        public int NumModified { get; set; }

        /// <summary>
        /// Number of lines removed in the pull request, according to GitHub.
        /// </summary>
        public int NumRemoved { get; set; }

        /// <summary>
        /// The pull requests unique number ID in GitHub.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The ID of the target branch for the particular pull request.
        /// </summary>
        public int TargetBranchId { get; set; }

        /// <summary>
        /// The title of the pull request.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The URL for the pull request.
        /// </summary>
        public string Url { get; set; }
    }
}
