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

    public interface IStoryLinkResource : IStoryLinkResource<StoryLink, int>
    { }

    public interface IStoryLinkResource<TModel, TKey> :
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IDeletable<TKey> where TModel : ClubHouseModel<TKey>
    {
    }
}
