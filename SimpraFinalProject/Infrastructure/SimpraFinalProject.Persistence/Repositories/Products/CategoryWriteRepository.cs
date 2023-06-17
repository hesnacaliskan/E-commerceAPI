using SimpraFinalProject.Application.Repositories.Products;
using SimpraFinalProject.Domain.Entities;
using SimpraFinalProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Persistence.Repositories.Categories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(SimpraFinalProjectDbContext context) : base(context)
        {
        }
    }
}
