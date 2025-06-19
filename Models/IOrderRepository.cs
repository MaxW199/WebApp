using System;

namespace PiesShop.Models;

public interface IOrderRepository
{
    void CreateOrder(Order order);
}
