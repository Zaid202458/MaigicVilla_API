using MaigicVilla_VillaAPI.Models;

namespace MaigicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
