using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Models
{
    public class Customer
    {
        public Customer()
        {
            Values = new List<Value>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Telno { get; set; }
        public int UserId { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }
        public List<Value> Values { get; set; }
        public User User { get; set; }
    }
}
