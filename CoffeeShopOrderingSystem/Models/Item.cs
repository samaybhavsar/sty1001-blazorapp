using System;
using System.Collections.Generic;

namespace CoffeeShopOrderingSystem.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public int? ItemCalories { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemImage { get; set; }
    }
}
