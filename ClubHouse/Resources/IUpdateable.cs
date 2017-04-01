using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IUpdateable<TModel, TInput, TKey> where TInput : ClubHouseModel<TKey>
    {
        Task<TModel> Update<TInputModel>(TInputModel model) where TInputModel : ClubHouseModel<TKey>;
    }
}
