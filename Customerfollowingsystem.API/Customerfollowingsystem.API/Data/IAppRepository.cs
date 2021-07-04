using Customerfollowingsystem.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customerfollowingsystem.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();
        List<Customer> GetCustomers();
        List<Value> GetValuesByCustomers(int id);
        Customer GetCustomerByID(int customerId);
        Value GetValue(int id);
    }
}
