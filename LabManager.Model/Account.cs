using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManager.Model
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHolder { get; set; }
        public ICollection<Role> UserRoles { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public DateTime DateJoined { get; set; }

        public ICollection<Role> Roles { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
