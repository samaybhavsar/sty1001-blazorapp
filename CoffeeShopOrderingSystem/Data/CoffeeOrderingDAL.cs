using System;
using CoffeeShopOrderingSystem.Models;

namespace CoffeeShopOrderingSystem.Data
{
    public class CoffeeOrderingDAL : IDisposable
    {
        public void Dispose()
        {

        }

        public void saveItems(Item Item)
        {
            using (cambriancoffeeshopContext ctx = new cambriancoffeeshopContext())
            {
                ctx.Items.Add(Item);
                ctx.SaveChanges();
            }      
        }

        public List<Item> getItems()
        {
            using (cambriancoffeeshopContext ctx = new cambriancoffeeshopContext())
            {
                return ctx.Items.ToList();
            }    
        }

        public Item getItemByID(int id)
        {
            using (cambriancoffeeshopContext ctx = new cambriancoffeeshopContext())
            {
                return ctx.Items.Where(item => item.ItemId == id).First();

            }

        }

        public CoffeeOrderingDAL()
        {
        }
    }
}

