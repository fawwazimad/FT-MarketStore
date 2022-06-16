using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductCarts = new HashSet<ProductCart>();
        }

        public decimal ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSale { get; set; }
        public decimal? ProductPrice { get; set; }
        public DateTime? ExDate { get; set; }
        public string ProductInfo { get; set; }
        public string ImagePath { get; set; }
        public decimal? StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual ICollection<ProductCart> ProductCarts { get; set; }
    }
}
