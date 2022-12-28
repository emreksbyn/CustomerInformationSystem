using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        Task<List<Customer>> GetCustomersDetailsAsync();
        Task<Customer> GetCustomerDetailsByIdAsync(int id);
        Task AddCustomerWithDependentsAsync(Customer customer);
        Task AddRangeCustomersWithDependentsAsync(List<Customer> customers);
        Task UpdateCustomerWithDependentsAsync(Customer customer);
        Task UpdateRangeCustomersWithDependentsAsync(List<Customer> customers);
        Task DeleteCustomerWithDependentsAsync(int id);
        Task DeleteRangeCustomersWithDependentsAsync(List<int> ids);
    }
}