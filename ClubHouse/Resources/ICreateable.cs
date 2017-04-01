using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface ICreateable<TModel, TInput, TKey> where TInput : ClubHouseModel<TKey>
    {
        Task<TModel> Create<TInputModel>(TInputModel model) where TInputModel : ClubHouseModel<TKey>;
    }


}
