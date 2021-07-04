using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customerfollowingsystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Customerfollowingsystem.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Value> Values { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
