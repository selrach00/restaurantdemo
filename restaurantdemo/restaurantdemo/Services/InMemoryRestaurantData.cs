using restaurantdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantdemo.Services
{


    public class InMemoryRestaurantdata : IRestaurantData
    {

        public InMemoryRestaurantdata()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza Place" },
                new Restaurant { Id = 2, Name = "Tersiguels" },
                new Restaurant { Id = 3, Name = "King's Contrivance" }
            };

        }
       
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}
