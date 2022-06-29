using Burger_Shop.Models.Domain;

namespace Burger_Shop.Database
{
    public static class BurgerDatabase
    {
        public static List<Ingredient> INGREDIENTS = new List<Ingredient>()
        {
            new Ingredient() {Id = 1, Name ="Plain bun"},
            new Ingredient() {Id = 2, Name ="Sesame bun"},
            new Ingredient() {Id = 3, Name ="Ciabatta bun"},
            new Ingredient() {Id = 4, Name ="Brioche bun"},
            new Ingredient() {Id = 5, Name ="Lettuce bun"},
            new Ingredient() {Id = 6, Name ="Tomato"},
            new Ingredient() {Id = 7, Name ="Red onion"},
            new Ingredient() {Id = 8, Name ="Caramelized onion"},
            new Ingredient() {Id = 9, Name =" Grilled onion"},
            new Ingredient() {Id = 10, Name ="Lettuce"},
            new Ingredient() {Id = 11, Name ="Pickles"},
            new Ingredient() {Id = 12, Name ="Cucumber"},
            new Ingredient() {Id = 13, Name ="Baby spinach"},
            new Ingredient() {Id = 14, Name ="Coleslaw"},
            new Ingredient() {Id = 15, Name ="Mozzarella"},
            new Ingredient() {Id = 16, Name ="Blue cheese"},
            new Ingredient() {Id = 17, Name ="Cheddar"},
            new Ingredient() {Id = 18, Name ="Goat cheese"},
            new Ingredient() {Id = 19, Name ="Egg"},
            new Ingredient() {Id = 20, Name ="Bacon"},
            new Ingredient() {Id = 21, Name ="Hot bacon"},
            new Ingredient() {Id = 22, Name ="Paprika"},
            new Ingredient() {Id = 23, Name ="Olives"},
            new Ingredient() {Id = 24, Name ="Curry sauce"},
            new Ingredient() {Id = 25, Name ="Mayonnaise"},
            new Ingredient() {Id = 26, Name ="Ketchup"},
            new Ingredient() {Id = 27, Name ="Chilli sauce"},
            new Ingredient() {Id = 28, Name ="BBQ"},
            new Ingredient() {Id = 29, Name ="Mustard"},
            new Ingredient() {Id = 30, Name ="Corn"},
            new Ingredient() {Id = 31, Name ="Beef"},
            new Ingredient() {Id = 32, Name ="Grilled mushrooms"},
            new Ingredient() {Id = 33, Name ="Tuna"},
            new Ingredient() {Id = 34, Name ="Veggie patty"},
            new Ingredient() {Id = 35, Name ="Sour cream"},
            new Ingredient() {Id = 36, Name ="Garlic powder"},
            new Ingredient() {Id = 37, Name ="Chili powder"},
            new Ingredient() {Id = 38, Name ="Black beans"},
            new Ingredient() {Id = 39, Name ="Hummus"}
        };

        public static List<Burger> BURGERS = new List<Burger>()
        {
            new Burger(){Id = 1, Name ="Glory Burger", Price = 10m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 7, 
                PhotoUrl = "https://media.istockphoto.com/photos/home-made-hamburger-with-lettuce-and-cheese-picture-id1397681885?s=612x612", 
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[0],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[11],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[25]
                                                                           }
            },
            new Burger(){Id = 2, Name ="Monk Burger", Price = 8.50m, IsVegetarian = false, IsVegan = false, HasFries = false, Rating = 10, 
                PhotoUrl = "https://img.freepik.com/free-photo/meat-burger-wooden-board-coleslaw-cucumber-tomato-mushrooms-cheese-side-view_141793-2387.jpg",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[0],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[21],
                                                                               INGREDIENTS[22],
                                                                               INGREDIENTS[13],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[31]
                                                                           }
            },
            new Burger(){Id = 3, Name ="Infinity Burger", Price = 13m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 10, 
                PhotoUrl = "https://media.istockphoto.com/photos/fresh-homemade-hamburger-served-on-wood-picture-id519490902",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[1],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[10],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[19],
                                                                               INGREDIENTS[19],
                                                                               INGREDIENTS[23],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[27]
                                                                           }
            },
            new Burger(){Id = 4, Name ="Surfin' Burger", Price = 11.50m, IsVegetarian = false, IsVegan = false, HasFries = false, Rating = 9,
                PhotoUrl ="https://image.shutterstock.com/image-photo/two-tuna-fish-sweetcorn-sandwich-600w-1478333126.jpg",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[1],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[29],
                                                                               INGREDIENTS[32],
                                                                               INGREDIENTS[33],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[22],
                                                                               INGREDIENTS[24]
                                                                           }
            },
            new Burger(){Id = 5, Name ="Limited Burger", Price = 12.5m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 8, 
                PhotoUrl ="https://media.istockphoto.com/photos/chef-showing-a-veggie-hamburger-picture-id1174719148?s=612x612",
                Ingredients = new List<Ingredient>()
                                                                          {
                                                                             INGREDIENTS[3],
                                                                             INGREDIENTS[5],
                                                                             INGREDIENTS[8],
                                                                             INGREDIENTS[21],
                                                                             INGREDIENTS[30],
                                                                             INGREDIENTS[20],
                                                                             INGREDIENTS[26],
                                                                             INGREDIENTS[24]
                                                                          }
            },
            new Burger(){Id = 6, Name ="Hyper Burger", Price = 11.99m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 9,
                PhotoUrl = "https://previews.123rf.com/images/handmadepictures/handmadepictures1509/handmadepictures150900626/45273846-ciabatta-burger-with-homemade-french-fries-on-rustic-background.jpg",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[2],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[7],
                                                                               INGREDIENTS[34],
                                                                               INGREDIENTS[21],
                                                                               INGREDIENTS[20],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[30]
                                                                           }
            },
            new Burger(){Id = 7, Name ="Mozza Burger", Price = 12.99m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 9, 
                PhotoUrl = "https://media.istockphoto.com/photos/tasty-burgers-on-wooden-table-picture-id860411132?", 
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[0],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[24]
                                                                           }
            },
            new Burger(){Id = 8, Name ="Smoke n' Cheese Burger", Price = 15.50m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 10, 
                PhotoUrl = "https://media.istockphoto.com/photos/steakhouse-double-bacon-cheeseburger-picture-id617759204",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[2],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[7],
                                                                               INGREDIENTS[10],
                                                                               INGREDIENTS[15],
                                                                               INGREDIENTS[17],
                                                                               INGREDIENTS[16],
                                                                               INGREDIENTS[20],
                                                                               INGREDIENTS[23],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[27],
                                                                               INGREDIENTS[28],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[30]
                                                                           }
            },
            new Burger(){Id = 9, Name ="Fame Burger", Price = 13m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 8,
                PhotoUrl ="https://media-cdn.tripadvisor.com/media/photo-s/1b/b0/7d/bb/epic-cheeseburger.jpg", 
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[1],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[29],
                                                                               INGREDIENTS[32],
                                                                               INGREDIENTS[33],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[22]
                                                                           }
            },
            new Burger(){Id = 10, Name ="Cheesy Hill Burger", Price = 15.99m, IsVegetarian = false, IsVegan = false, HasFries = true, Rating = 10, 
                PhotoUrl = "https://www.tfninternational.com/wp-content/uploads/2021/05/Feature-2-1536x1024.jpg",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[2],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[8],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[11],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[17],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[19],
                                                                               INGREDIENTS[20],
                                                                               INGREDIENTS[23],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[27],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[34],
                                                                               INGREDIENTS[30]
                                                                           }
            },
            new Burger(){Id = 11, Name ="Buddha Burger", Price = 12.50m, IsVegetarian = true, IsVegan = false, HasFries = true, Rating = 8,
                PhotoUrl ="https://i.pinimg.com/474x/95/1d/74/951d74a05992d26a1e60e4ec8398d277.jpg", 
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[4],
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[9],
                                                                               INGREDIENTS[18],
                                                                               INGREDIENTS[22],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[21],
                                                                               INGREDIENTS[33]
                                                                           }
            },
            new Burger(){Id = 12, Name ="Nature Burger", Price = 11m, IsVegetarian = true, IsVegan = true, HasFries = true, Rating = 7, 
                PhotoUrl = "https://media.istockphoto.com/photos/healthy-baked-sweet-potato-burger-with-whole-grain-bun-guacamole-picture-id905921648?",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[7],
                                                                               INGREDIENTS[12],
                                                                               INGREDIENTS[14],
                                                                               INGREDIENTS[22],
                                                                               INGREDIENTS[23],
                                                                               INGREDIENTS[24],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[30],
                                                                               INGREDIENTS[34]
                                                                           }
            },
            new Burger(){Id = 13, Name ="The Meatless Boss Burger", Price = 14m, IsVegetarian = true, IsVegan = true, HasFries = true, Rating = 8, 
                PhotoUrl = "https://img.taste.com.au/XRRXBWDp/taste/2019/09/vegan-burger-in-a-lettuce-bun-154173-2.jpg",
                Ingredients = new List<Ingredient>()
                                                                           {
                                                                               INGREDIENTS[5],
                                                                               INGREDIENTS[6],
                                                                               INGREDIENTS[11],
                                                                               INGREDIENTS[13],
                                                                               INGREDIENTS[21],
                                                                               INGREDIENTS[22],
                                                                               INGREDIENTS[25],
                                                                               INGREDIENTS[26],
                                                                               INGREDIENTS[29],
                                                                               INGREDIENTS[33],
                                                                               INGREDIENTS[34],
                                                                               INGREDIENTS[35],
                                                                               INGREDIENTS[36],
                                                                               INGREDIENTS[37],
                                                                               INGREDIENTS[38]
                                                                           }
            }
        };

        public static List<Order> ORDERS = new List<Order>()
        {
            new Order() {Id = 1, FullName = "Rick Novak", Address = "600 S. Brookhurst Ave. CA 82154",
                IsDelivered = true, Location = "Boron CA",
                Burgers = new List<Burger>()
                                                               {
                                                                   BURGERS[2],
                                                                   BURGERS[1],
                                                                   BURGERS[1],
                                                                   BURGERS[2],
                                                                   BURGERS[8]
                                                               }
            },
            new Order() {Id = 2, FullName = "Marie Lum", Address = "55 Willie Stargell Ave., CA 94854", 
                IsDelivered = true, Location = "Alhambra CA",
                Burgers = new List<Burger>()
                                                               {
                                                                   BURGERS[0],
                                                                   BURGERS.Last(),
                                                                   BURGERS.Find(x => x.IsVegetarian = true ),
                                                                   BURGERS.Find(x => x.Price > 12),
                                                                   BURGERS.Find(x => x.HasFries = false)
                                                               }
            },
            new Order() {Id = 3, FullName = "Susan Connor", Address = "5646 N. Santa Anita., CA 92807", 
                IsDelivered = true, Location = "Martell CA",
                Burgers = new List<Burger>()
                                                               {
                                                                   BURGERS[0],
                                                                   BURGERS[0],
                                                                   BURGERS[0],
                                                                   BURGERS[4],
                                                                   BURGERS[8]
                                                               }
            },
            new Order() {Id = 4, FullName = "Jeff Johnson", Address = "1165 E. La Palma, CA 93420",
                IsDelivered = true, Location = "Murrieta CA",
                Burgers = new List<Burger>()
                                                               {
                                                                   BURGERS.Find(x=> x.Price > 14),
                                                                   BURGERS[6],
                                                                   BURGERS[10],
                                                                   BURGERS.Find(x => x.IngredientsCounter() > 5),
                                                                   BURGERS[12]
                                                               }
            }
        };

        public static int GetNextOrderId()
        {
            return (ORDERS.OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
        }
    }
}





