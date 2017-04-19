using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IGettable<TModel, TKey>
        where TModel : ClubHouseModel<TKey>

    {
        /// <summary>
        /// Gets the specified Clubhouse resource by Id
        /// </summary>
        /// <param name="id">The Id of the resource to fetch</param>
        /// <returns></returns>
        Task<TModel> Get(TKey id);
    }
}
