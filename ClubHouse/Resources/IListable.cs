using ClubHouse.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IListable<TModel, TKey>
        where TModel : ClubHouseModel<TKey>

    {
        Task<IReadOnlyList<TModel>> List();
    }
}
