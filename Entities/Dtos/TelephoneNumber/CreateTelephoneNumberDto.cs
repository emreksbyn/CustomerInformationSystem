using Core.Entities;

namespace Entities.Dtos.TelephoneNumber
{
    public class CreateTelephoneNumberDto : IDto
    {
        public string Description { get; set; }
        public string TelephoneNo { get; set; }
        public int CustomerId { get; set; }
    }
}