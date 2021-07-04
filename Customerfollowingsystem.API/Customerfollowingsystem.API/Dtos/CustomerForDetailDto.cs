using Customerfollowingsystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Dtos
{
    public class CustomerForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Telno { get; set; }
        public string Adress { get; set; }
        public List<Value> Values { get; set; }
    }
}
