using MagicVilla_VillaApi.Models;
using MagicVilla_VillaApi.Repository.IRepository;

using System.Linq.Expressions;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IVillaRepository : IRepository <Villa>
    {

        Task<Villa> UpdateAsync(Villa entity);

    }
}
