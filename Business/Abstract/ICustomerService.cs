using Core.Responses;
using Entities.Dtos.Customer;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<IResponse<List<CustomerDto>>> GetAllAsync();
        Task<IResponse<CustomerDto>> GetByIdAsync(int id);
        Task<IResponse<NoContent>> AddAsync(CreateCustomerDto createCustomerDto);
        Task<IResponse<NoContent>> UpdateAsync(UpdateCustomerDto updateCustomerDto);
        Task<IResponse<NoContent>> DeleteAsync(CustomerDto customerDto);
    }
}