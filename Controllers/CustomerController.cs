using Microsoft.AspNetCore.Mvc;
using DataDashboard.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Http.HttpResults;
namespace DataDashboard.Controllers
 {
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CustomerController(AppDbContext _context)
        {
            _context = context;
        }

    }
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<CustomerDetails>>> GetCustomer(int id)
    {
        var Customer = await _context.CustomerDetails.FromSqlRaw("select * from Customer = {0}",id);
        if(string.IsNullOrEmpty(Customer))
        {
            return BadRequest("Customer does not haver orders");
        }
        else
        {
            return Customer;
        }
    }

 }