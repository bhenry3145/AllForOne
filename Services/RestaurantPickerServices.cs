using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOne.Models;

namespace AllForOne.Services
{
    public class RestaurantPickerServices
    {

        public List<Restaurant> restaurants = [
            new Restaurant {Id = 1, RestaurantName = "El Torito", RestaurantType = "Mexican"},
            new Restaurant {Id = 2, RestaurantName = "Casa Flores", RestaurantType = "Mexican"},
            new Restaurant {Id = 3, RestaurantName = "Adalberto's", RestaurantType = "Mexican"},
            new Restaurant {Id = 4, RestaurantName = "Carolina's Grill and Taqueria", RestaurantType = "Mexican"},
            new Restaurant {Id = 5, RestaurantName = "Octavio's", RestaurantType = "Mexican"},
            new Restaurant {Id = 6, RestaurantName = "Arroyo's", RestaurantType = "Mexican"},
            new Restaurant {Id = 7, RestaurantName = "Nena's", RestaurantType = "Mexican"},
            new Restaurant {Id = 8, RestaurantName = "Las Palmas", RestaurantType = "Mexican"},
            new Restaurant {Id = 9, RestaurantName = "Cancun", RestaurantType = "Mexican"},
            new Restaurant {Id = 10, RestaurantName = "Alberto's Mexican Food", RestaurantType = "Mexican"},
            new Restaurant {Id = 11, RestaurantName = "Mandarin Villa Express", RestaurantType = "Chinese"},
            new Restaurant {Id = 12, RestaurantName = "Tsing Tao Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 13, RestaurantName = "Dynasty Food Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 14, RestaurantName = "Dave Wong's", RestaurantType = "Chinese"},
            new Restaurant {Id = 15, RestaurantName = "Sherman's Chinese Buffet", RestaurantType = "Chinese"},
            new Restaurant {Id = 16, RestaurantName = "China Village Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 17, RestaurantName = "China Palace Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 18, RestaurantName = "Beijing Buffet", RestaurantType = "Chinese"},
            new Restaurant {Id = 19, RestaurantName = "Yen Du Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 20, RestaurantName = "New Yen Ching Restaurant", RestaurantType = "Chinese"},
            new Restaurant {Id = 21, RestaurantName = "McDonald's", RestaurantType = "Fast Food"},
            new Restaurant {Id = 22, RestaurantName = "Burger King", RestaurantType = "Fast Food"},
            new Restaurant {Id = 23, RestaurantName = "In n Out Burger", RestaurantType = "Fast Food"},
            new Restaurant {Id = 24, RestaurantName = "Wendy's", RestaurantType = "Fast Food"},
            new Restaurant {Id = 25, RestaurantName = "Taco Bell", RestaurantType = "Fast Food"},
            new Restaurant {Id = 26, RestaurantName = "Chick-fil-a", RestaurantType = "Fast Food"},
            new Restaurant {Id = 27, RestaurantName = "Sonic", RestaurantType = "Fast Food"},
            new Restaurant {Id = 28, RestaurantName = "KFC", RestaurantType = "Fast Food"},
            new Restaurant {Id = 29, RestaurantName = "Popeyes", RestaurantType = "Fast Food"},
            new Restaurant {Id = 30, RestaurantName = "Deltaco", RestaurantType = "Fast Food"}
        ];
        public string response = "";
        public int randomNum;
        public Random rng = new Random();
        public bool runs;

        public string GetRestaurant(string category)
        {
            runs = (category.Contains("Mexican") || category.Contains("Chinese") || category.Contains("Fast Food"));
            if (runs == false)
            {
                response = "Please select from one of the categories: Mexican, Chinese, or Fast Food";
            }
            else
            {
                if (category.Contains("Mexican"))
                {
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "El Torito";
                            break;

                        case 2:
                            response = "Casa Flores";
                            break;

                        case 3:
                            response = "Adalberto's";
                            break;

                        case 4:
                            response = "Carolina's Grill and Taqueria";
                            break;

                        case 5:
                            response = "Octavio's";
                            break;

                        case 6:
                            response = "Arroyo's";
                            break;

                        case 7:
                            response = "Nena's";
                            break;

                        case 8:
                            response = "Las Palmas";
                            break;

                        case 9:
                            response = "Cancun";
                            break;

                        case 10:
                            response = "Alberto's Mexican Food";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
                else if (category.Contains("Chinese"))
                {
                    int newNum;
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "Mandarin Villa Express";
                            break;

                        case 2:
                            response = "Tsing Tao Restaurant";
                            break;

                        case 3:
                            response = "Dynasty Food Restaurant";
                            break;

                        case 4:
                            response = "Dave Wong's";
                            break;

                        case 5:
                            response = "Sherman's Chinese Buffet";
                            break;

                        case 6:
                            response = "China Village Restaurant";
                            break;

                        case 7:
                            response = "China Palace Restaurant";
                            break;

                        case 8:
                            response = "Beijing Buffet";
                            break;

                        case 9:
                            response = "Yen Du Restaurant";
                            break;

                        case 10:
                            response = "New Yen Ching Restaurant";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
                else if (category.Contains("Fast Food"))
                {
                    randomNum = rng.Next(1, 11);
                    switch (randomNum)
                    {
                        case 1:
                            response = "McDonald's";
                            break;

                        case 2:
                            response = "Burger King";
                            break;

                        case 3:
                            response = "In n Out Burger";
                            break;

                        case 4:
                            response = "Wendy's";
                            break;

                        case 5:
                            response = "Taco Bell";
                            break;

                        case 6:
                            response = "Chick-fil-a";
                            break;

                        case 7:
                            response = "Sonic";
                            break;

                        case 8:
                            response = "KFC";
                            break;

                        case 9:
                            response = "Popeyes";
                            break;

                        case 10:
                            response = "Del Taco";
                            break;

                        default:
                            response = "This restaurant is permanently closed so it's not listed.";
                            break;
                    }
                }
            }
            return response;
        }
    }
}