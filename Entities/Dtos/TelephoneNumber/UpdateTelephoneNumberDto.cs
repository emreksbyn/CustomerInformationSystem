using Core.Entities;
using Entities.Dtos.Customer;

namespace Entities.Dtos.TelephoneNumber
{
    public class UpdateTelephoneNumberDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string TelephoneNo { get; set; }
        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}