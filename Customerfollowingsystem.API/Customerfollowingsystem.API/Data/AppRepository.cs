using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customerfollowingsystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Customerfollowingsystem.API.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Customer GetCustomerByID(int customerId)
        {
            var customer = _context.Customers.Include(c => c.User).FirstOrDefault(c => c.Id == customerId);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            var customers = _context.Customers.Include(c => c.User).ToList();
            return customers;
        }

        public Value GetValue(int id)
        {
            var values = _context.Values.FirstOrDefault(v => v.Id == id);
            return values;
        }

        public List<Value> GetValuesByCustomers(int id)
        {
            var values = _context.Values.Where(v => v.CustomerId == id).ToList();
            return values;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
