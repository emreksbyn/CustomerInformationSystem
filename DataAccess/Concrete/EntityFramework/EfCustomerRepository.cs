using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerRepository : EfEntityRepositoryBase<Customer, CustomerInformationDbContext>, ICustomerRepository
    {
        public Task AddCustomerWithDependentsAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeCustomersWithDependentsAsync(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomerWithDependentsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeCustomersWithDependentsAsync(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetCustomersDetailsAsync()
        {
            using (var context = new CustomerInformationDbContext())
            {
                List<Customer> result = await context.Customers
                    .Include(c => c.Addresses)
                    .Include(c => c.TelephoneNumbers)
                    .ToListAsync();

                return result;
                #region deneme
                //List<CustomerDetailsDto> customerDetailsList = new();
                //foreach (var item in result)
                //{
                //    CustomerDetailsDto customerDetails = new();
                //    customerDetails.Id = item.Id;
                //    customerDetails.Name = item.Name;
                //    customerDetails.Surname = item.Surname;
                //    customerDetails.TcNo = item.TcNo;
                //    customerDetails.Email = item.Email;
                //} 
                #endregion
            }
        }

        public Task UpdateCustomerWithDependentsAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeCustomersWithDependentsAsync(List<Customer> customers)
        {
            throw new NotImplementedException();
        }
    }
}