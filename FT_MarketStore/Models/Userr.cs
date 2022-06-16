using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Userr
    {
        public Userr()
        {
            Carts = new HashSet<Cart>();
            UserLogins = new HashSet<UserLogin>();
        }

        public decimal UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal? UserBalance { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
