﻿using Core.Entities;

namespace Entities.Dtos.Address
{
    public class UpdateAddressDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int CustomerId { get; set; }
    }
}