using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.Address;
using Entities.Dtos.Customer;
using Entities.Dtos.TelephoneNumber;

namespace Business.Mapping.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();

            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, UpdateAddressDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();

            CreateMap<TelephoneNumber, CreateTelephoneNumberDto>().ReverseMap();
            CreateMap<TelephoneNumber, UpdateTelephoneNumberDto>().ReverseMap();
            CreateMap<TelephoneNumber, TelephoneNumberDto>().ReverseMap();
        }
    }
}