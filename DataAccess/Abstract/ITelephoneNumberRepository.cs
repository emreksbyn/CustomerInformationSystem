using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ITelephoneNumberRepository : IEntityRepository<TelephoneNumber>
    {
        Task<List<TelephoneNumber>> GetByCustomerIdAsync(int id);
        Task DeleteByIdAsync(int id);
    }
}