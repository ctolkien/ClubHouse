using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class UserResource : Resource<User, string>, IUserResource
    {
        protected override string ResourceName => "users";
        internal UserResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }

    public interface IUserResource : IUserResource<User, string>
    {

    }

    public interface IUserResource<TModel, TKey> :
        IListable<TModel, TKey>,
        IGettable<TModel, TKey> where TModel : ClubHouseModel<TKey>
    {
    }
}
