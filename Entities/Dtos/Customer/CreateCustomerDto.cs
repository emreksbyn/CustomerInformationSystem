using Core.Entities;

namespace Entities.Dtos.Customer
{
    public class CreateCustomerDto : IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
    }
}