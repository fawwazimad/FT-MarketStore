using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Category
    {
        public Category()
        {
            Stores = new HashSet<Store>();
        }

        public decimal CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
