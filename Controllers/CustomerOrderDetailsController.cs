using Microsoft.AspNetCore.Mvc;
using DataDashboard.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Http.HttpResults;
namespace DataDashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerOrderDetails{
        private readonly AppDbContext _context;
        public CustomerOrderDetails(AppDbContext context)
        {
            _context = context;
        }

       
        }

}
