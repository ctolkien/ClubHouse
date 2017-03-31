using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class LabelResource : Resource<Label, int>, ILabelResource
    {
        protected override string ResourceName => "labels";

        internal LabelResource(ClubHouseHttpClient client) : base(client)
        {
        }

    }

    public interface ILabelResource : IListable<Label>
    {

    }
}
