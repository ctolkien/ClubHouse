using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IListable<T>
    {
        Task<IList<T>> List();
    }
}
