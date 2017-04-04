using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    internal class EpicResource : Resource<Epic, int>, IEpicResource
    {
        protected override string ResourceName => "epics";

        internal EpicResource(ClubHouseHttpClient client) : base(client)
        {
        }

        public Task<Epic> Update(EpicUpdate model)
        {
            return base.Update(model);
        }
    }

    public interface IEpicResource :
        IListable<Epic, int>,
        ICreateable<Epic, Epic, int>,
        IGettable<Epic, int>,
        IUpdateable<Epic, EpicUpdate, int>,
        IDeletable<int>
    {
    }
}
