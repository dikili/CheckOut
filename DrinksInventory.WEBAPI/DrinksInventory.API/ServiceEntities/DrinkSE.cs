using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksInventory.API.ServiceEntities
{
    public class DrinkSE
    {
       public int Id { get; set; }
       public string Name { get; set; }
        public int Quantity { get; set; }
    }
}