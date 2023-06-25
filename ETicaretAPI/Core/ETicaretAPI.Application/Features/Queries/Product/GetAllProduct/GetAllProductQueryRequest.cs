using ETicaretAPI.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryRequest : IRequest<List<GetAllProductQueryResponse>>
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        
        public DateTime? UpdatedDate { get; set; }        
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}