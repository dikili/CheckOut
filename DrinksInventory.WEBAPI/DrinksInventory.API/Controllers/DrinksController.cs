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

        public DrinksController(IDrinkRepository repo)
        {
            _drinkRepo = repo;
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
        public bool Post(string name,int quantity)
        {
            var id = _drinkRepo.GetLastDrinkId();
            try
            {
                _drinkRepo.AddDrink(new Drink {Id = id + 1, Name = name, Quantity = quantity});
                return true;
            }
            catch (Exception)
            {
                return false;}
           
        }

        // PUT api/values/5
        [HttpPut]
        [Route("PutDrink/{id}/{quantity}")]
        public bool Put(int id, int quantity)
        {
            var drink= _drinkRepo.GetDrink(id);
            try
            {
                _drinkRepo.UpdateDrink(id, quantity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("DeleteADrink/{id}")]
        public bool Delete(int id)
        {
            try
            {
                _drinkRepo.DeleteDrink(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
            
        }
    }
}
