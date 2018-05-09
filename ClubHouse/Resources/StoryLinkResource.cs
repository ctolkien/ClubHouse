using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class StoryLinkResource : Resource<StoryLink, int>, IStoryLinkResource
    {
        protected override string ResourceName => "story-links";

        internal StoryLinkResource(HttpClient client) : base(client)
        {
        }
    }

    public interface IStoryLinkResource :
        ICreateable<StoryLink, StoryLink, int>,
        IGettable<StoryLink, int>,
        IDeletable<int>
    {
    }
}
