using SimpraFinalProject.Application.Repositories.Categories;
using SimpraFinalProject.Domain.Entities;
using SimpraFinalProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Persistence.Repositories.Categories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(SimpraFinalProjectDbContext context) : base(context)
        {
        }
    }
}
