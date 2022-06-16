using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Store
    {
        public Store()
        {
            Products = new HashSet<Product>();
        }

        public decimal StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreImage { get; set; }
        public decimal? StorePhone { get; set; }
        public string StoreEmail { get; set; }
        public string StoreCity { get; set; }
        public string StoreInfo { get; set; }
        public decimal? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
