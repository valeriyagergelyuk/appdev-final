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
        private String title;
        private String description;
        private decimal price;
        private int inStock;
        private int daysToShip;
        //private image;

        public Item(int id, String title, String description, decimal price, int stock, int daysToShip)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.inStock = stock;
            this.daysToShip = daysToShip;
        }
    }
}
