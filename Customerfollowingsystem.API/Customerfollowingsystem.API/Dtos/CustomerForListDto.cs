using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Dtos
{
    public class CustomerForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Telno { get; set; }
        public int Updatetime { get; set; }
        public string Adress { get; set; }
    }
}
