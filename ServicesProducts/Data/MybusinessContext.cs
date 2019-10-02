using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServicesProducts.Models
{
    public class MybusinessContext : DbContext
    {
        public MybusinessContext (DbContextOptions<MybusinessContext> options)
            : base(options)
        {
        }

        public DbSet<ServicesProducts.Models.Products> Products { get; set; }
    }
}
