using İntroApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İntroApi.Services
{
    public class FakeRestaurantService :IRestaurantService
    {
        private  List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,Name="Köfteci yusuf -fake"},
                new Restaurant{Id=2,Name="burgerkıng -fake"},
                new Restaurant { Id = 3, Name = "Mcdonals -fake" },


            };
        public IList<Restaurant> GetRestaurants()
        {
            return restaurants;
        }

    }
}
