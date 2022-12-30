using Entities.Dtos.Address;
using Entities.Dtos.TelephoneNumber;

namespace Entities.Dtos.Customer
{
    public class CreateCustomerDetailsDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }

        public List<CreateAddressDto> Addresses { get; set; }
        public List<CreateTelephoneNumberDto> TelephoneNumbers { get; set; }
    }
}