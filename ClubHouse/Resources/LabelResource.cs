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

        public Task<LabelWithCounts> Create(Label model)
        {
            return base.Create(model);
        }

        public Task<LabelWithCounts> Update(Label model)
        {
            return base.Update(model);
        }
    }

    public interface ILabelResource :
        IListable<LabelWithCounts, int>,
        ICreateable<LabelWithCounts, Label, int>,
        IUpdateable<LabelWithCounts, Label, int>,
        IDeletable<int>
    {

    }
}
