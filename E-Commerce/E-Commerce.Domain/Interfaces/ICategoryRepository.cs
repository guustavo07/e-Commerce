﻿using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<Category> GetById(int id);
}
