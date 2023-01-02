using AutoMapper;
using Business.Abstract;
using Core.Responses;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos.Address;

namespace Business.Concrete
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<NoContent>> AddAsync(CreateAddressDto createAddressDto)
        {
            Address address = _mapper.Map<Address>(createAddressDto);
            await _addressRepository.AddAsync(address);
            return Response<NoContent>.Success("Adres başarı ile eklendi.");
        }

        public async Task<IResponse<NoContent>> DeleteAsync(AddressDto addressDto)
        {
            Address address = _mapper.Map<Address>(addressDto);
            await _addressRepository.DeleteAsync(address);
            return Response<NoContent>.Success("Adres başarı ile silindi.");
        }

        public async Task<IResponse<NoContent>> DeleteByIdAsync(int id)
        {
            await _addressRepository.DeleteByIdAsync(id);
            return Response<NoContent>.Success("Adres başarı ile silindi.");
        }

        public async Task<IResponse<List<AddressDto>>> GetAllAsync()
        {
            List<Address> addresses = await _addressRepository.GetAllAsync();
            List<AddressDto> addressDtos = _mapper.Map<List<AddressDto>>(addresses);
            return Response<List<AddressDto>>.Success(addressDtos, "Adresler listelendi.");
        }

        public async Task<IResponse<List<AddressDto>>> GetByCustomerIdAsync(int customerId)
        {
            List<Address> addresses = await _addressRepository.GetByCustomerIdAsync(customerId);
            List<AddressDto> addressDtos = _mapper.Map<List<AddressDto>>(addresses);
            return Response<List<AddressDto>>.Success(addressDtos, "Adresler müşteriye göre listelendi.");
        }

        public async Task<IResponse<AddressDto>> GetByIdAsync(int id)
        {
            Address address = await _addressRepository.GetAsync(x => x.Id == id);
            AddressDto addressDto = _mapper.Map<AddressDto>(address);
            return Response<AddressDto>.Success(addressDto, "Adres id ye göre getirildi.");
        }

        public async Task<IResponse<NoContent>> UpdateAsync(UpdateAddressDto updateAddressDto)
        {
            Address address = _mapper.Map<Address>(updateAddressDto);
            await _addressRepository.UpdateAsync(address);
            return Response<NoContent>.Success("Adres başarı ile güncellendi.");
        }
    }
}