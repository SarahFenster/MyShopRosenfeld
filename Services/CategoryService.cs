﻿using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _CategoryRepository;
        public CategoryService(ICategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _CategoryRepository.GetCategories();

        }
    }
}
