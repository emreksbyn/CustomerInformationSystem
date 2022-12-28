using Core.Entities;
using Entities.Dtos.Address;
using Entities.Dtos.TelephoneNumber;

namespace Entities.Dtos.Customer
{
    public class CreateCustomerDto : IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }

        public List<CreateAddressDto> Addresses { get; set; }
        public List<CreateTelephoneNumberDto> TelephoneNumbers { get; set; }
    }
}