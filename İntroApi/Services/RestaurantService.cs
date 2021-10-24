using İntroApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İntroApi.Services
{
    public class RestaurantService :IRestaurantService
    {

        public IList<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>
           {

                new Restaurant{Id=1,Name="Köfteci yusuf -db"},
                new Restaurant{Id=2,Name="burgerkıng  -db" },
                new Restaurant { Id = 3, Name = "Mcdonals -db" },


            };
        }



    }
}
