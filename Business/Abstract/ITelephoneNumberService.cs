using Core.Responses;
using Entities.Dtos.TelephoneNumber;

namespace Business.Abstract
{
    public interface ITelephoneNumberService
    {
        Task<IResponse<List<TelephoneNumberDto>>> GetAllAsync();
        Task<IResponse<TelephoneNumberDto>> GetByIdAsync(int id);
        Task<IResponse<NoContent>> AddAsync(CreateTelephoneNumberDto createTelephoneNumberDto);
        Task<IResponse<NoContent>> UpdateAsync(UpdateTelephoneNumberDto updateTelephoneNumberDto);
        Task<IResponse<NoContent>> DeleteAsync(TelephoneNumberDto telephoneNumberDto);
    }
}