using İntroApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İntroApi.Services
{
    public class ExcelRestaurantService : IRestaurantService
    {
        public IList<Restaurant> GetRestaurants()
        {
           return new List<Restaurant>
           {
                
                new Restaurant{Id=1,Name="Köfteci yusuf -excel"},
                new Restaurant{Id=2,Name="burgerkıng -excel" },
                new Restaurant { Id = 3, Name = "Mcdonals -excel" },


            };
        
        }
    }
}
