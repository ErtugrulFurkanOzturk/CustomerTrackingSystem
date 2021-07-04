using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string Server { get; set; }
        public int Updatetime { get; set; }
        public string Sector { get; set; }
        public bool IsMain { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
