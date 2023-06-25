using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Categories.CreateCategory
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public DateTime? CreatedAt { get; set; }        
        public DateTime? UpdatedAt { get; set; }        
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
