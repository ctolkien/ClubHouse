using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{

    public interface IUpdateable<TModel, TInput, TKey> where TModel : ClubHouseModel<TKey>
    {
        Task<TModel> Update(TInput model);
    }



}
