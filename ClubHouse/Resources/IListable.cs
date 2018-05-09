using ClubHouse.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    /// <summary>
    /// Represents a Clubhouse resource which supports listing
    /// </summary>
    /// <typeparam name="TModel">The type of resource</typeparam>
    /// <typeparam name="TKey">The type of key used by the <see cref="TModel"/> resource</typeparam>
    public interface IListable<TModel, TKey>
        where TModel : ClubHouseModel<TKey>

    {
        /// <summary>
        /// List the resources
        /// </summary>
        /// <returns>A <see cref="IReadOnlyList{T}"/> of TModel </returns>
        Task<IReadOnlyList<TModel>> List();
    }
}
