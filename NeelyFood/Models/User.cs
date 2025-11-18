using System.Collections.Generic;

namespace NeelyFood.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin" أو "Customer"

        public virtual ICollection<Order> Orders { get; set; }
    }
}
