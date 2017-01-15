using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DrinksInventory.API.ServiceEntities;
using DrinksInventory.Data.Entities;

namespace DrinksInventory.API.App_Start
{
    public class MapperConfig
    {
        public MapperConfig()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Drink, DrinkSE>();
            });
        }

     
      
    }
}