using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness
{
    internal class Order
    {
        private Item item;
        private String usernameBuyer;
        private DateTime confirmation;
        private DateTime orderArrival;
        private String status;

        public Order(Item item, string usernameBuyer, DateTime orderArrival)
        {
            this.item = item;
            this.usernameBuyer = usernameBuyer;
            this.confirmation = DateTime.Now;
            this.orderArrival = orderArrival;
            this.status = "Order made";
        }
    }
}
