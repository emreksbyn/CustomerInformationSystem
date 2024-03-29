﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTelephoneNumberRepository : EfEntityRepositoryBase<TelephoneNumber, CustomerInformationDbContext>, ITelephoneNumberRepository
    {
        public async Task DeleteByIdAsync(int id)
        {
            using (var context = new CustomerInformationDbContext())
            {
                TelephoneNumber telephoneNumber = await context.TelephoneNumbers.FindAsync(id);
                context.Remove(telephoneNumber);
                await context.SaveChangesAsync();
            }
        }
        public async Task<List<TelephoneNumber>> GetByCustomerIdAsync(int id)
        {
            using (var context = new CustomerInformationDbContext())
            {
                return await context.TelephoneNumbers.Where(t => t.CustomerId == id).ToListAsync();
            }
        }
    }
}
