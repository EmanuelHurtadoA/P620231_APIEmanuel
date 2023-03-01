using System;
using System.Collections.Generic;

namespace P620231_API.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            Users = new HashSet<User>();
        }

        public int UserStatusId { get; set; }
        public string UserStatuDescription { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
