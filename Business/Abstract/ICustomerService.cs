using Core.Responses;
using Entities.Concrete;
using Entities.Dtos.Customer;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<IResponse<List<CustomerDto>>> GetAllAsync();
        Task<IResponse<List<CustomerDetailsDto>>> GetCustomersDetailsAsync();

        Task<IResponse<CustomerDto>> GetByIdAsync(int id);
        Task<IResponse<CustomerDetailsDto>> GetCustomerDetailsByIdAsync(int id);

        Task<IResponse<NoContent>> AddAsync(CreateCustomerDto createCustomerDto);
        Task<IResponse<NoContent>> AddCustomerWithDependentsAsync(CustomerDetailsDto customer);
        Task<IResponse<NoContent>> AddRangeCustomersWithDependentsAsync(List<CustomerDetailsDto> customers);

        Task<IResponse<NoContent>> UpdateAsync(UpdateCustomerDto updateCustomerDto);
        Task<IResponse<NoContent>> UpdateCustomerWithDependentsAsync(CustomerDetailsDto customer);
        Task<IResponse<NoContent>> UpdateRangeCustomersWithDependentsAsync(List<CustomerDetailsDto> customers);

        Task<IResponse<NoContent>> DeleteAsync(CustomerDto customerDto);
        Task<IResponse<NoContent>> DeleteCustomerWithDependentsAsync(int id);
        Task<IResponse<NoContent>> DeleteRangeCustomersWithDependentsAsync(List<int> ids);
    }
}