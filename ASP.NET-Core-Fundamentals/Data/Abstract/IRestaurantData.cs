using System.Collections.Generic;
using Core;

namespace Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetByName(string name);

    }
}