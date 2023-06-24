using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpraFinalProject.Domain.Common;
using SimpraFinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Domain.Entities
{
    [Table("Product", Schema = "dbo")]
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<Category> Categories { get; set; }


    }

  
}
