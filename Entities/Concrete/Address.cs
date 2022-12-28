using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Address : BaseEntity<int>
    {
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}