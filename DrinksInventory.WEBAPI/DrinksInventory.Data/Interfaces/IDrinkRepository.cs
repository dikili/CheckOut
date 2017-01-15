using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksInventory.Data.Entities;

namespace DrinksInventory.Data.Interfaces
{
   public interface IDrinkRepository
    {
        IList<Drink> GetAllDrinks();
        Drink GetDrink(int drinkId);

        void DeleteDrink(int drinkId);

        void AddDrink(Drink newDrink);
        void UpdateDrink(int id,int quantity);

        int GetLastDrinkId();

    }
    
}
