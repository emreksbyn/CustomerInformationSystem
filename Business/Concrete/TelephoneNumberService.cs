using AutoMapper;
using Business.Abstract;
using Core.Responses;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.TelephoneNumber;

namespace Business.Concrete
{
    public class TelephoneNumberService : ITelephoneNumberService
    {
        private readonly ITelephoneNumberRepository _telephoneNumberRepository;
        private readonly IMapper _mapper;
        public TelephoneNumberService(ITelephoneNumberRepository telephoneNumberRepository, IMapper mapper)
        {
            _telephoneNumberRepository = telephoneNumberRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<NoContent>> AddAsync(CreateTelephoneNumberDto createTelephoneNumberDto)
        {
            TelephoneNumber telephoneNumber = _mapper.Map<TelephoneNumber>(createTelephoneNumberDto);
            await _telephoneNumberRepository.AddAsync(telephoneNumber);
            return Response<NoContent>.Success("Telefon numarası başarı ile eklendi.");
        }

        public async Task<IResponse<NoContent>> DeleteAsync(TelephoneNumberDto telephoneNumberDto)
        {
            TelephoneNumber telephoneNumber = _mapper.Map<TelephoneNumber>(telephoneNumberDto);
            await _telephoneNumberRepository.DeleteAsync(telephoneNumber);
            return Response<NoContent>.Success("Telefon numarası başarı ile silindi.");
        }

        public async Task<IResponse<List<TelephoneNumberDto>>> GetAllAsync()
        {
            List<TelephoneNumber> telephoneNumbers = await _telephoneNumberRepository.GetAllAsync();
            List<TelephoneNumberDto> telephoneNumberDtos = _mapper.Map<List<TelephoneNumberDto>>(telephoneNumbers);
            return Response<List<TelephoneNumberDto>>.Success(telephoneNumberDtos, "Telefon numaraları listelendi.");
        }

        public async Task<IResponse<List<TelephoneNumberDto>>> GetByCustomerIdAsync(int customerId)
        {
            List<TelephoneNumber> telephoneNumbers = await _telephoneNumberRepository.GetByCustomerIdAsync(customerId);
            List<TelephoneNumberDto> telephoneNumberDtos = _mapper.Map<List<TelephoneNumberDto>>(telephoneNumbers);
            return Response<List<TelephoneNumberDto>>.Success(telephoneNumberDtos, "Telefon numaraları müşteriye göre listelendi.");
        }

        public async Task<IResponse<TelephoneNumberDto>> GetByIdAsync(int id)
        {
            TelephoneNumber telephoneNumber = await _telephoneNumberRepository.GetAsync(x => x.Id == id);
            TelephoneNumberDto telephoneNumberDto = _mapper.Map<TelephoneNumberDto>(telephoneNumber);
            return Response<TelephoneNumberDto>.Success(telephoneNumberDto, "Telefon numarası id ye göre getirildi.");
        }

        public async Task<IResponse<NoContent>> UpdateAsync(UpdateTelephoneNumberDto updateTelephoneNumberDto)
        {
            TelephoneNumber telephoneNumber = _mapper.Map<TelephoneNumber>(updateTelephoneNumberDto);
            await _telephoneNumberRepository.UpdateAsync(telephoneNumber);
            return Response<NoContent>.Success("Telefon numarası başarı ile güncellendi.");
        }
    }
}