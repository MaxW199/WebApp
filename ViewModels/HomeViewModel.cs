using System;
using PiesShop.Models;

namespace PiesShop.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Pie> PiesOfTheWeek { get; }
    public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
    {
        PiesOfTheWeek = piesOfTheWeek;
    }
}
