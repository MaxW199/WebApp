using System;
using Microsoft.AspNetCore.Mvc;
using PiesShop.Models;
using PiesShop.ViewModels;

namespace PiesShop.Components;

public class ShoppingCartSummary : ViewComponent
{
    private readonly IShoppingCart _shoppingCart;
    public ShoppingCartSummary(IShoppingCart shoppingCart)
    {
        _shoppingCart = shoppingCart;
    }

    public IViewComponentResult Invoke()
    {
        var items = _shoppingCart.GetShoppingCartItems();
        _shoppingCart.ShoppingCartItems = items;

        var shoppingCartViewModel = new ShoppingCartViewModel
        (
            _shoppingCart,
            _shoppingCart.GetShoppingCartTotal()
        );

        return View(shoppingCartViewModel);
    }

}
