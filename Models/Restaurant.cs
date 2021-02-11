using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Restaurant
    {
        //constructor to set read-only values
        public Restaurant(int rank)
        {
            Rank = rank;
        }

        //readonly value
        [Required]
        public int Rank { get; }

        [Required]
        public string Name { get; set; }

        public string FavoriteDish { get; set; }

        [Required]
        public string Address { get; set; }

        public string Phone { get; set; }

        //includes an initializer in the event of a null entry
        public string WebsiteURL { get; set; } = "Coming soon.";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Benihana",
                FavoriteDish = "Samurai Treat",
                Address = "165 S W Temple, Salt Lake City, UT 84101",
                Phone = "801-322-2421",
                WebsiteURL = "www.benihana.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Texas Roadhouse",
                FavoriteDish = null,
                Address = "1265 S State St, Orem, UT 84097",
                Phone = "801-226-2724",
                WebsiteURL = "www.texasroadhouse.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Leatherby's Family Creamery",
                FavoriteDish = "Kenny's Milkshake",
                Address = "304 E University Pkwy, Orem, UT 84058",
                Phone = "385-223-8140"
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "Five Sushi Brothers",
                FavoriteDish = null,
                Address = "445 Freedom Blvd 200 W, Provo, UT 84601",
                Phone = "385-549-4495",
                WebsiteURL = "fivesushibrothers.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Brick Oven Pizza",
                FavoriteDish = "The Sampler",
                Address = "111 E 800 N, Provo, UT 84606",
                Phone = "801 374-8800",
                WebsiteURL = "brickovenrestaurants.com"
            };
            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
