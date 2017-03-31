using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IDeletable<T>
    {
        Task Delete(T id);
    }
}
