using System;

namespace PiesShop.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
}
