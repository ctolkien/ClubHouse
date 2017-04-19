using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface ICreateable<TModel, TInput, TKey>
        where TInput : ClubHouseModel<TKey>
        where TModel : ClubHouseModel<TKey>
    {
        /// <summary>
        /// Creates a new Clubhouse resource
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<TModel> Create(TInput model);
    }
}
