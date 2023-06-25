using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        
        
        public string Description { get; set; }
        public string Address { get; set; }

        public string OrderCode { get; set; }

        public Basket Basket { get; set; }
        

        public CompletedOrder CompletedOrder { get; set; }
    }
}
