using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class ProjectResource : Resource<Project, int>, IProjectResource
    {
        protected override string ResourceName => "projects";

        internal ProjectResource(ClubHouseHttpClient client) : base(client)
        {
        }

        //TODO: List Stories
    }

    public interface IProjectResource : IProjectResource<Project, int>
    {
    }

    public interface IProjectResource<TModel, TKey> :
        IListable<TModel>,
        IGettable<TModel, TKey>,
        IUpdateable<TModel>,
        ICreateable<TModel>,
        IDeletable<TKey>
    {
    }
}
