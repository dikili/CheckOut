using System;
using System.Collections.Generic;

using System.Web.Http;
using AutoMapper;
using DrinksInventory.API.Authorization;
using DrinksInventory.API.ServiceEntities;
using DrinksInventory.Data.Entities;
using DrinksInventory.Data.Interfaces;
using DrinksInventory.Data.Repositories;


namespace DrinksInventory.API.Controllers
{
    [DrinksApiAuthorize]
    [RoutePrefix("api")]
    public class DrinksController : ApiController 
    {

        private IDrinkRepository _drinkRepo;

        public DrinksController()
        {
            _drinkRepo =new DrinkListRepository();
        }
        // GET api/values
        [HttpGet]
        [Route("GetDrinks")]
        public IEnumerable<Drink> Get()
        {
            return _drinkRepo.GetAllDrinks();
        }

        // GET api/values/5
        [HttpGet]
        [Route("GetDrink/{id}")]
        public Drink Get(int id)
        {
            return _drinkRepo.GetDrink(id);
        }

        // POST api/values
        [HttpPost]
        [Route("PostDrink/{name}/{quantity}")]
        public void Post(string name,int quantity)
        {
            var id = _drinkRepo.GetLastDrinkId();

            _drinkRepo.AddDrink(new Drink {Id = id + 1, Name = name,Quantity = quantity});
        }

        // PUT api/values/5
        [HttpPut]
        [Route("PutDrink/{id}/{quantity}")]
        public void Put(int id, int quantity)
        {
            var drink= _drinkRepo.GetDrink(id);

            _drinkRepo.UpdateDrink(id,quantity);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("DeleteADrink/{id}")]
        public void Delete(int id)
        {
            _drinkRepo.DeleteDrink(id);
        }
    }
}
