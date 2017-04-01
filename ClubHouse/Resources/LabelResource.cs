using System;
using System.Threading.Tasks;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class LabelResource : Resource<LabelWithCounts, int>, ILabelResource
    {
        protected override string ResourceName => "labels";

        internal LabelResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }

    public interface ILabelResource : ILabelResource<LabelWithCounts, int>
    { }

    public interface ILabelResource<TModel, TKey> :
        IListable<TModel, TKey>,
        ICreateable<TModel, Label, int>,
        IUpdateable<TModel, Label, int>,
        IDeletable<TKey> where TModel : ClubHouseModel<int>
    {

    }
}
