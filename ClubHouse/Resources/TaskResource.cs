using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class TaskResource : Resource<Task, int>,  ITaskResource
    {
        protected override string ResourceName => $"{_storyId}/tasks";
        private int _storyId;

        internal TaskResource(int storyId, HttpClient client) : base(client)
        {
            _storyId = storyId;
        }
    }

    public interface ITaskResource :
        ICreateable<Task, Task, int>,
        IGettable<Task, int>,
        IUpdateable<Task, Task, int>,
        IDeletable<int>
    {
    }
}
