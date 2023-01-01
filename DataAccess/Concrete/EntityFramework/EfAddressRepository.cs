﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAddressRepository : EfEntityRepositoryBase<Address, CustomerInformationDbContext>, IAddressRepository
    {
        public async Task<List<Address>> GetByCustomerIdAsync(int id)
        {
            using (var context = new CustomerInformationDbContext())
            {
                return await context.Addresses.Where(a => a.CustomerId == id).ToListAsync();
            }
        }
    }
}
