using Microsoft.AspNetCore.Mvc;
using DataDashboard.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
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
         var Product = await _context.Products.FindAsync(id);   
         if(Product == null)
         {
            return NotFound();
         }      
         else{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
                return Product ;
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

            }            
       }


       


    }

 }