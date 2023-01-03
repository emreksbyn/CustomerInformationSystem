using Entities.Dtos.Address;
using Entities.Dtos.TelephoneNumber;

namespace Entities.Dtos.Customer
{
    public class CustomerDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }

        public List<AddressDto> Addresses { get; set; }
        public List<TelephoneNumberDto> TelephoneNumbers { get; set; }

        public bool HaveUnsualName { get; set; }
    }
}