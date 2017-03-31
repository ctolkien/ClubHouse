using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class StoryLinkResource : Resource<StoryLink, int>, IStoryLinkResource
    {
        protected override string ResourceName => "story-links";
        internal StoryLinkResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }

    public interface IStoryLinkResource : ICreateable<StoryLink>, IGettable<StoryLink, int>, IDeletable<int>
    { }
}
