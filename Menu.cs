using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItems> Food { get; set; }


        public DateTime currentTime { get; set; }


        public Menu(List<MenuItems> food)
        {
            Food = food;
            currentTime = DateTime.Now;
        }

    }
}
