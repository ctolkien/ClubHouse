using ClubHouse.Models;
using System.Net.Http;

namespace ClubHouse.Resources
{
    internal class CategoryResource : Resource<Category, int>, ICategoryResource
    {
        internal CategoryResource(HttpClient client) : base(client)
        {
        }

        protected override string ResourceName => "categories";
    }

    public interface ICategoryResource :
        IListable<Category, int>,
        ICreateable<Category, Category, int>,
        IUpdateable<Category, Category, int>,
        IGettable<Category, int>,
        IDeletable<int>
    {
    }
}
