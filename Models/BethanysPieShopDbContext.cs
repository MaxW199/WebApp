using System;
using Microsoft.EntityFrameworkCore;

namespace PiesShop.Models;

public class BethanysPieShopDbContext : DbContext
{
    public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options)
        : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Pie> Pies { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

}
