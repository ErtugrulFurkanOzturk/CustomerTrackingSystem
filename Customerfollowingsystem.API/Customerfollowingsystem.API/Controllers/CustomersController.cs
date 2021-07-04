using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Customerfollowingsystem.API.Data;
using Customerfollowingsystem.API.Dtos;
using Customerfollowingsystem.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customerfollowingsystem.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    public class CustomersController : ControllerBase
    {
        private IAppRepository _appRepository;
        private IMapper _mapper;
        public CustomersController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetCustomers()
        {
            var customers = _appRepository.GetCustomers();
            var customersToReturn = _mapper.Map<List<CustomerForListDto>>(customers);
            return Ok(customersToReturn);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody] Customer customer)
        {
            _appRepository.Add(customer);
            _appRepository.SaveAll();
            return Ok(customer);
        }
        [HttpGet]
        [Route("detail")]
        public ActionResult GetCustomerById(int id)
        {
            var customer = _appRepository.GetCustomerByID(id);
            var customerToReturn = _mapper.Map<List<CustomerForDetailDto>>(customer);
            return Ok(customerToReturn);
        }
        [HttpGet]
        [Route("values")]
        public ActionResult GetValuesByCustomers(int id)
        {
            var values = _appRepository.GetValuesByCustomers(id);
            return Ok(values);
        }
    }
}