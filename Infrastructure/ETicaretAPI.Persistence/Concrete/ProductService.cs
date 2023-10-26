﻿using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new()
            {
                new()
                {Id = Guid.NewGuid(),Name = "Product 1",Price = 500,Stock = 100},
                new()
                {Id = Guid.NewGuid(),Name = "Product 2",Price = 300,Stock = 150},
                new()
                {Id = Guid.NewGuid(),Name = "Product 3",Price = 200,Stock = 120},
            };
    }
}
