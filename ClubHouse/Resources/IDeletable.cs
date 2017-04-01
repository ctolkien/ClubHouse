using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IDeletable<TKey>
    {
        Task Delete(TKey id);
    }
}
