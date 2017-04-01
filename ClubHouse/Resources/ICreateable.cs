using ClubHouse.Models;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    /// <summary>
    /// Supports creating resources
    /// </summary>
    /// <typeparam name="TModel">The type of model that will be returned</typeparam>
    /// <typeparam name="TInput">That type of model used as an input</typeparam>
    /// <typeparam name="TKey">The type of key used</typeparam>
    public interface ICreateable<TModel, TInput, TKey> where TInput : ClubHouseModel<TKey>
    {
        Task<TModel> Create<TInputModel>(TInputModel model) where TInputModel : ClubHouseModel<TKey>;
    }


}
