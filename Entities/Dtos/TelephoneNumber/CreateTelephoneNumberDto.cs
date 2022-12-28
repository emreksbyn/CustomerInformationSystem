using Core.Entities;
using Entities.Dtos.Customer;

namespace Entities.Dtos.TelephoneNumber
{
    public class CreateTelephoneNumberDto : IDto
    {
        public string Description { get; set; }
        public string TelephoneNo { get; set; }
        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}