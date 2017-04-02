using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class TaskResource : Resource<StoryTask, int>,  ITaskResource
    {
        protected override string ResourceName => $"{_storyId}/tasks";
        private int _storyId;

        internal TaskResource(int storyId, ClubHouseHttpClient client) : base(client)
        {
            _storyId = storyId;
        }
    }

    public interface ITaskResource :
        ICreateable<StoryTask, StoryTask, int>,
        IGettable<StoryTask, int>,
        IUpdateable<StoryTask, StoryTask, int>,
        IDeletable<int>
    {
    }
}
