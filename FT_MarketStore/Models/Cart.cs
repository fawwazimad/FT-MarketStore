using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Cart
    {
        public Cart()
        {
            ProductCarts = new HashSet<ProductCart>();
        }

        public decimal CardId { get; set; }
        public decimal? Userid { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Userr User { get; set; }
        public virtual ICollection<ProductCart> ProductCarts { get; set; }
    }
}
