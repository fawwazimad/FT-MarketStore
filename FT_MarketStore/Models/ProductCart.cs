using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class ProductCart
    {
        public decimal ProuctCartId { get; set; }
        public decimal? ProductId { get; set; }
        public decimal? CartId { get; set; } 

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
