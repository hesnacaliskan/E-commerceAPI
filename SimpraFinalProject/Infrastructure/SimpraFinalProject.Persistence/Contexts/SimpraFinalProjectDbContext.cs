using Microsoft.EntityFrameworkCore;
using SimpraFinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Persistence.Contexts
{
    public class SimpraFinalProjectDbContext : DbContext
    {
        public SimpraFinalProjectDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
