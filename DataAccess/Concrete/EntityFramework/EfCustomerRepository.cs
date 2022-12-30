using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerRepository : EfEntityRepositoryBase<Customer, CustomerInformationDbContext>, ICustomerRepository
    {
        #region Get
        public async Task<Customer> GetCustomerDetailsByIdAsync(int id)
        {
            using (var context = new CustomerInformationDbContext())
            {
                Customer result = await context.Customers
                    .Include(c => c.Addresses)
                    .Include(c => c.TelephoneNumbers)
                    .FirstOrDefaultAsync(c => c.Id == id);

                return result;
            }
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
            }
        }
        #endregion

        #region Add
        public async Task AddCustomerWithDependentsAsync(Customer customer)
        {
            using (var context = new CustomerInformationDbContext())
            {
                await context.Customers.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task AddRangeCustomersWithDependentsAsync(List<Customer> customers)
        {
            using (var context = new CustomerInformationDbContext())
            {
                await context.Customers.AddRangeAsync(customers);
                await context.SaveChangesAsync();
            }
        }
        #endregion

        #region Update
        public async Task UpdateCustomerWithDependentsAsync(Customer customer)
        {
            using (var context = new CustomerInformationDbContext())
            {
                context.Customers.Update(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateRangeCustomersWithDependentsAsync(List<Customer> customers)
        {
            using (var context = new CustomerInformationDbContext())
            {
                context.Customers.UpdateRange(customers);
                await context.SaveChangesAsync();
            }
        }
        #endregion

        #region Delete
        public async Task DeleteCustomerWithDependentsAsync(int id)
        {
            using (var context = new CustomerInformationDbContext())
            {
                Customer customer = await context.Customers.FirstOrDefaultAsync(c => c.Id == id);
                context.Customers.Remove(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteRangeCustomersWithDependentsAsync(List<int> ids)
        {
            using (var context = new CustomerInformationDbContext())
            {
                List<Customer> customerList = new List<Customer>();
                foreach (int id in ids)
                {
                    Customer customer = await context.Customers.FirstOrDefaultAsync(c => c.Id == id);
                    customerList.Add(customer);
                }
                context.Customers.RemoveRange(customerList);
                await context.SaveChangesAsync();
            }
        }
        #endregion
    }
}