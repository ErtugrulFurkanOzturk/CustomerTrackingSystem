using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Models
{
    public class User
    {
        public User()
        {
            Customers = new List<Customer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
