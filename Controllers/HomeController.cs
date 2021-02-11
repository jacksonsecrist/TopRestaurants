using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopRestaurants.Models;

namespace TopRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string favDish = r.FavoriteDish ?? "It's all tasty!";//if the value of favorite dish is null, show "Its all tasty!"
                string website;
                //we want to do one of two things depending on the value of websiteURL
                if(r.WebsiteURL != "Coming soon.") //if the url is not set to the initial value, render an <a> tag on the page with a link
                {
                    website = $"<a href='//{r.WebsiteURL}' target='_blank'>Go to their Website</a>";
                }
                else//otherwise, just display normal text equal to that initial value of "Coming Soon."
                {
                    website = r.WebsiteURL;
                }
                restaurantList.Add($"#{r.Rank} - {r.Name}<br>Favorite Dish: {favDish}<br>Address: {r.Address}<br>Phone: {r.Phone}<br>" + website);
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult AddSuggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSuggestion(RestaurantSuggestion newSuggestion)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(newSuggestion);
                return View("Confirmation", newSuggestion);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ViewSuggestions()
        {
            return View(TempStorage.RestaurantSuggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
