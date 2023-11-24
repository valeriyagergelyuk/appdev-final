using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusiness
{
    //i think this class will become useless after we create the database... but just for now
    internal class Account
    {

        //instance variables
        private String email;
        private String password;
        private String username;
        private List<Item> items;
        private List<Order> orders;


        public Account(String email, String password, String username)
        {
            this.email = email;
            this.password = password;
            this.username = username;
        }
    }
}
