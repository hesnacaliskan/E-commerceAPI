using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpraFinalProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Domain.Entities
{
    [Table("Category", Schema = "dbo")]
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public ICollection<Product> Products { get; set; }

    }
   
    
}
