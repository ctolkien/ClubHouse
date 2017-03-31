using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClubHouse.Resources
{
    public interface IUpdateable<TModel>
    {
        Task<TModel> Update(TModel model);
    }
}
