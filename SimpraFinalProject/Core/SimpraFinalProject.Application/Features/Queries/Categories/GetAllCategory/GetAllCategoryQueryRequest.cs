using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Application.Features.Queries.Categories.GetAllCategory
{
    public class GetAllCategoryQueryRequest : IRequest<List<GetAllCategoryQueryResponse>>
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
       
    }
}
