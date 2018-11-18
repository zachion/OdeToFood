using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestautantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant(){Id = 1, Name = "Zachs Restaurant"},
                new Restaurant(){Id = 2, Name = "Fallafel Place"},
                new Restaurant(){Id = 3, Name = "Kings Cross Restaurants"},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}
