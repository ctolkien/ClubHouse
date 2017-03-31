using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IGettable<T, TKey>
    {
        Task<T> Get(TKey id);
    }
}
