using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IUpdateable<TModel, TInput, TKey>
        where TModel : ClubHouseModel<TKey>
        where TInput : ClubHouseModel<TKey>
    {
        /// <summary>
        /// Updates the provided item in Clubhouse
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<TModel> Update(TInput model);
    }
}
