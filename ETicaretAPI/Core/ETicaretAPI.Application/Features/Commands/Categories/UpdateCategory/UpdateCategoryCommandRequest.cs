using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Categories.UpdateCategory
{
    public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse>
    {
        public string Id { get; set; }
        public DateTime? CreatedAt { get; set; }        
        public DateTime? UpdatedAt { get; set; }        
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
