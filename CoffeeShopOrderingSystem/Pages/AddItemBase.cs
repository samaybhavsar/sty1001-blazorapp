using System;
using CoffeeShopOrderingSystem.Data;
using CoffeeShopOrderingSystem.Models;
using Microsoft.AspNetCore.Components;

namespace AddItemBase
{
    
    public class AddItemBase : ComponentBase
    {

        public Item Item
        {
            get;
            set;
        }

        protected override Task OnInitializedAsync()
        {
            Item = new Item();

            return base.OnInitializedAsync();
        }

        public void SaveItem()
        {
            using(CoffeeOrderingDAL dal = new CoffeeOrderingDAL())
            {
                dal.saveItems(Item);
            }
        }

        public List<Item> GetItems()
        {
            using(CoffeeOrderingDAL dal = new CoffeeOrderingDAL())
            {
                List<Item> items = dal.getItems();
                return items;
            }
        }

        public Item GetItemByID(int id)
        {
            using (CoffeeOrderingDAL dal = new CoffeeOrderingDAL())
            {
                Item item = dal.getItemByID(id);
                return item;
            }
        }
    }
}

