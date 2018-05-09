using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// The results of the search query.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// A list of search results.
        /// </summary>
        public IReadOnlyCollection<StorySearch> Data { get; set; }

        /// <summary>
        /// The next page token.
        /// </summary>
        public string Next { get; set; }

        /// <summary>
        /// The total number of matches for the search query.
        /// </summary>
        public int Total { get; set; }
    }
}
