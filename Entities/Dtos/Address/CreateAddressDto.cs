﻿using Core.Entities;
using Entities.Dtos.Customer;

namespace Entities.Dtos.Address
{
    public class CreateAddressDto : IDto
    {
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int CustomerId { get; set; }
        public CustomerDto Customer { get; set; }
    }
}