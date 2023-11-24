using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness
{
    internal class Item
    {
        //instance variables
        private int id;
        private int incrementID = 1;
        private String title;
        private String description;
        private decimal price;
        private int inStock;
        private String username;
        private int daysToShip;
        //private image;

        public Item(String title, String description, decimal price, int stock, String username, int daysToShip)
        {
            this.id = incrementID++;
            this.title = title;
            this.description = description;
            this.price = price;
            this.inStock = stock;
            this.username = username;
            this.daysToShip = daysToShip;
        }
    }
}
