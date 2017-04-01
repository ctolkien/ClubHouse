using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class TaskResource : Resource<StoryTask, int>,  ITaskResource
    {
        protected override string ResourceName => $"{_storyId}/tasks";
        private int _storyId;

        public TaskResource(int storyId, ClubHouseHttpClient client) : base(client)
        {
            _storyId = storyId;
        }

    }

    public interface ITaskResource : ITaskResource<StoryTask, int>
    {
    }
    public interface ITaskResource<TModel, TKey> :
        ICreateable<TModel, TModel, TKey>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel, TModel, TKey>,
        IDeletable<TKey>
        where TModel : ClubHouseModel<TKey>
    {

    }

}
