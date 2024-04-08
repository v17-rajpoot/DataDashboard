using Microsoft.AspNetCore.Mvc;
using DataDashboard.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
namespace DataDashboard.Controllers
 {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductReadController : ControllerBase
    
    {
      private readonly AppDbContext _context;
       public ProductReadController(AppDbContext context)
       {
         _context = context;
       }


       [HttpGet("{id}")]
       public async Task<ActionResult<Product>> GetProduct(int id)
       {
         var product = await _context.Products.FindAsync(id);   
         return product?.Name != null ? product  : NotFound();           
       }
       [HttpGet("Search")]
       public async Task<ActionResult<Product>> SearchProducts(string name)
       {
         if(string.IsNullOrEmpty(name))
         {
            return BadRequest("Product name is not found");       
         }
         else{
            string SQLquery = $"Select {name} from Products";
            //return await _context.Products.where(p=>p.name.contains(name)).ToListAsync();
            return await _context.Products.FromSqlRaw(SQLquery).ToListAsync;
         }
       }
    }

 }