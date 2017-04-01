using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface ICreateable<TModel, TInput, TKey> where TInput : ClubHouseModel<TKey>
    {
        Task<TModel> Create(TInput model);
    }


}
