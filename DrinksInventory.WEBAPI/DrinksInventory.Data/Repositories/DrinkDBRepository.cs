using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksInventory.Data.Entities;
using DrinksInventory.Data.Interfaces;

namespace DrinksInventory.Data.Repositories
{
    public class DrinkDBRepository :IDrinkRepository
    {
        public IList<Drink> GetAllDrinks()
        {
            throw new NotImplementedException();
        }

        public Drink GetDrink(int drinkId)
        {
            throw new NotImplementedException();
        }

        public void DeleteDrink(int drinkId)
        {
            throw new NotImplementedException();
        }

        public void AddDrink(Drink newDrink)
        {
            throw new NotImplementedException();
        }

        public void UpdateDrink(int id, int quantity)
        {
            throw new NotImplementedException();
        }

        public int GetLastDrinkId()
        {
            throw new NotImplementedException();
        }
    }
}
