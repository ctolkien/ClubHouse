using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IGettable<TModel, TKey>
        where TModel : ClubHouseModel<TKey>

    {
        Task<TModel> Get(TKey id);
    }
}
