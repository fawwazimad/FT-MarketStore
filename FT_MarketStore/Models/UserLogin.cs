using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class UserLogin
    {
        public decimal LoginId { get; set; }
        public string Email { get; set; }
        public string Passwordd { get; set; }
        public decimal? UserId { get; set; }
        public decimal? RoleId { get; set; }

        public virtual Rolee Role { get; set; }
        public virtual Userr User { get; set; }
    }
}
