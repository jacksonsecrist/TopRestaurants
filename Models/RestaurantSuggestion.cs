using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class RestaurantSuggestion
    {
        public string SuggesterName { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; }

        [RegularExpression("^\\d{3}-\\d{3}-\\d{4}$")]
        public string Phone { get; set; }
    }
}
