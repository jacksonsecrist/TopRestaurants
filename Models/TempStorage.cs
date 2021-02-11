using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class TempStorage
    {
        private static List<RestaurantSuggestion> restaurantSuggestions = new List<RestaurantSuggestion>();

        public static IEnumerable<RestaurantSuggestion> RestaurantSuggestions => restaurantSuggestions;

        public static void AddSuggestion(RestaurantSuggestion newSuggestion)
        {
            restaurantSuggestions.Add(newSuggestion);
        }
    }
}
