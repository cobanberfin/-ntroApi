using İntroApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İntroApi.Services
{
    public interface IRestaurantService
    {
        IList<Restaurant> GetRestaurants();
    } 

}
