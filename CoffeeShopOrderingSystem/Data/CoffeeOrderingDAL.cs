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
        public CoffeeOrderingDAL()
        {
        }
    }
}

