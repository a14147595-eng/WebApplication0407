using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication0407.Models;


namespace WebApplication0407.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
      
        public DbSet<Product> Products { get; set; }
    }
}
