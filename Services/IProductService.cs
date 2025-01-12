﻿using Entities;

namespace Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
    }
}