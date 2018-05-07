using System.Net.Http;
using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class LabelResource : Resource<Label, int>, ILabelResource
    {
        protected override string ResourceName => "labels";

        internal LabelResource(HttpClient client) : base(client)
        {
        }
    }

    public interface ILabelResource :
        IListable<Label, int>,
        IGettable<Label, int>,
        ICreateable<Label, Label, int>,
        IUpdateable<Label, Label, int>,
        IDeletable<int>
    {
    }
}
