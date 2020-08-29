using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASP.NET_Core_Fundementals.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public IEnumerable<Restaurant> Restaurants { get; private set; }
        [BindProperty(SupportsGet = true)] public string SearchTerm { get; set; }

        private IRestaurantData _restaurantData;

        public ListModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            System.Console.WriteLine(SearchTerm);
            if (string.IsNullOrEmpty(SearchTerm)) Restaurants = _restaurantData.GetAll();
            else Restaurants = _restaurantData.GetByName(SearchTerm);

        }
    }
}