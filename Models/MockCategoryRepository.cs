using System;

namespace PiesShop.Models;

public class MockCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories => new List<Category>
    {
        new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description = "All fruit pies" },
        new Category { CategoryId = 2, CategoryName = "Cheese Pies", Description = "Cheesy goodness" },
        new Category { CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Seasonal delights" }
    };
}
