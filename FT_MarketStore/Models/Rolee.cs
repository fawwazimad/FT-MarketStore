using System;
using System.Collections.Generic;

#nullable disable

namespace FT_MarketStore.Models
{
    public partial class Rolee
    {
        public Rolee()
        {
            UserLogins = new HashSet<UserLogin>();
        }

        public decimal RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
