using Core;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Scott's Pizza", Location = "Maryland", CuisineType = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Amit's Borrito", Location = "Kidron", CuisineType = CuisineType.Mexican},
                new Restaurant {Id = 3, Name = "Dana's Bakery", Location = "Ramot Meier", CuisineType = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from restaurant in _restaurants
                   orderby restaurant.Name
                   select restaurant;
        }

        public IEnumerable<Restaurant> GetByName(string name)
        {
            return from restaurant in _restaurants
                   where restaurant.Name.ToLower().StartsWith(name.ToLower())
                   orderby restaurant.Name
                   select restaurant;
        }
    }
}
