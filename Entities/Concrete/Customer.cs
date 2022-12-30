using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Customer : BaseEntity<int>
    {
        public Customer()
        {
            Addresses = new List<Address>();
            TelephoneNumbers = new List<TelephoneNumber>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }

        public List<Address> Addresses { get; set; }
        public List<TelephoneNumber> TelephoneNumbers { get; set; }

        public Customer(int id, string name, string surname, string tcNo, string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            TcNo = tcNo;
            Email = email;
        }
    }
}