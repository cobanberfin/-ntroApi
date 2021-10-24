using İntroApi.Models;
using İntroApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İntroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        IRestaurantService restaurantService;
        public RestaurantsController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }



        [HttpGet]
        public IActionResult GetRestaurants()
        {
            
            var restaurants = restaurantService.GetRestaurants();


            return Ok(restaurants);//bu koleksıyonları kullanmam ıcınr estoren servsıne erişebıır olmam lazım
        }

        // o restoranta ait menü bilgisi
        [HttpGet("{id}")]   //url den ıd gelcek.metotta kulanılabılcek
        IActionResult GetRestaurant(int id) //id parametre al bu ıd ıle eslesen restaurant dondur. 
        {
            var restaurants = restaurantService.GetRestaurants();


            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);  

            if (restaurant != null)
            {
                return Ok(restaurant);
            }
            //return NotFound();
            return BadRequest(new { Message = $"{id} id li bir restaurant" });
        }

        [HttpGet("Search/{cityId}")]

        public IActionResult GetRestaurantByCity(int cityId)
        {
            return Ok();
        }


        [HttpPost] //request gönderılıyor 

        public IActionResult AddRestaurant(Restaurant restaurant)
        {
            if (ModelState.IsValid) //name yı bos gecmıs mı gecmemıs mı burda yanı butun kurallara uyulduysa
            {
                var restaurants = restaurantService.GetRestaurants();

                restaurants.Add(restaurant);
                restaurant.Id = restaurants[restaurants.Count - 1].Id + 1;

            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]//unik olmalı ıd verılmelı
        public IActionResult UpdateRestaurant(int id, Restaurant newRestaurant)
        {//bu ıd de urun varmı guncelle

            if (id > 0)
            {
                if (ModelState.IsValid)
                {
                    //guncellendı...
                    return Ok(newRestaurant);                                       //guncellenme bıterse ne dondurcek
                }
                return BadRequest(ModelState);

            }
            return NotFound();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRestaurant(int id)
        {
            //silindi
            return Ok();
        }
        
       
    }
}




