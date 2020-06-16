using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Vidly.App_Start;
using Vidly.Dtos;
using Vidly.Models;
using AppContext = Vidly.Models.AppContext;


namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private AppContext _context;
      //  public IMapper _mapper;

        public CustomersController()
        {
            _context = new AppContext();
            //_mapper = mapper;
        }
        //Get /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            var results = _context.Customers.ToList();
          //  var mappedEntityies = _mapper.Map<CustomerDto>(results);
            return results;
        }
        //Get /api/customers
        public Customer GetCustomer(int id)
        {
          var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
          if (customer == null)
              throw new HttpResponseException(HttpStatusCode.NotFound);
          return customer;
        }

        //POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
                throw  new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }
        //PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);
            if(customerInDb==null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerInDb.Name = customer.Name;
            customerInDb.BirthDate = customer.BirthDate;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter; 
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            _context.SaveChanges();
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);
            if(customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
