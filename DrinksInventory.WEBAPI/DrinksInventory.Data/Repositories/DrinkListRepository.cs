using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DrinksInventory.Data.Entities;
using DrinksInventory.Data.Interfaces;

namespace DrinksInventory.Data.Repositories
{
    public class DrinkListRepository :IDrinkRepository
    {
        private static List<Drink> drinkRepo;
        static DrinkListRepository()
        {
            drinkRepo= new List<Drink> {
                        new Drink{Id=1,Name="Pepsi",Quantity = 3},
                        new Drink{Id=2,Name="Cola" , Quantity = 5},
                        new Drink{Id=3,Name="Ayran" ,Quantity = 7},

                     };

        }
      

        public IList<Drink> GetAllDrinks()
        {
            return drinkRepo;
        }

        public Drink GetDrink(int drinkId)
        {
            return drinkRepo.Find(p => p.Id == drinkId);
        }

        public void DeleteDrink(int drinkId)
        {
            var drink= drinkRepo.Find(p => p.Id == drinkId);
            if (drink != null)
            {
                drinkRepo.Remove(drink);
            }
            else
            {
                throw new Exception();
            }

        }


        public void AddDrink(Drink newDrink)
        {
            if (drinkRepo.Find(p => p.Name == newDrink.Name) == null)
            {
                drinkRepo.Add(newDrink);

            }
            else
            {
                throw new Exception();
            }
           
        }

        public void UpdateDrink(int id, int quantity)
        {
            var drink = drinkRepo.Find(p => p.Id == id);
            if (drink != null)
            {
                drink.Quantity = quantity;
            }
            else
            {
                throw new Exception();
            }

        }

        public int GetLastDrinkId()
        {
            var item =
                drinkRepo.LastOrDefault();

            if (item != null) return item.Id;

            return 0;
        }
    }
}
