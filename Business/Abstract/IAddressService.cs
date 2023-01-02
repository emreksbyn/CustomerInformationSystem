using Core.Responses;
using Entities.Dtos.Address;

namespace Business.Abstract
{
    public interface IAddressService
    {
        Task<IResponse<List<AddressDto>>> GetAllAsync();
        Task<IResponse<AddressDto>> GetByIdAsync(int id);
        Task<IResponse<List<AddressDto>>> GetByCustomerIdAsync(int customerId);
        Task<IResponse<NoContent>> AddAsync(CreateAddressDto createAddressDto);
        Task<IResponse<NoContent>> UpdateAsync(UpdateAddressDto updateAddressDto);
        Task<IResponse<NoContent>> DeleteAsync(AddressDto addressDto);
        Task<IResponse<NoContent>> DeleteByIdAsync(int id);
    }
}