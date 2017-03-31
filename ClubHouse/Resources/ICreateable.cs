using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface ICreateable<TModel>
    {
        Task<TModel> Create(TModel model);
    }
}
