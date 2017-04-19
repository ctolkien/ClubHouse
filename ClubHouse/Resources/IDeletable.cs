using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IDeletable<TKey>
    {
        /// <summary>
        /// Deletes the specified Clubhouse resource by Id
        /// </summary>
        /// <param name="id">The Id of the resource to delete</param>
        /// <returns></returns>
        Task Delete(TKey id);
    }
}
