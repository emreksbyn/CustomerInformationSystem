using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class TelephoneNumber : BaseEntity<int>
    {
        public string Description { get; set; }
        public string TelephoneNo { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public TelephoneNumber()
        {

        }

        public TelephoneNumber(int id, string description, string telephoneNo, int customerId)
        {
            Id = id;
            Description = description;
            TelephoneNo = telephoneNo;
            CustomerId = customerId;
        }
    }
}