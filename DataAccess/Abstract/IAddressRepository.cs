using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAddressRepository : IEntityRepository<Address>
    {
        Task<List<Address>> GetByCustomerIdAsync(int id);
        Task DeleteByIdAsync(int id);
    }
}