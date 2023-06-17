using MediatR;
using SimpraFinalProject.Application.Repositories.Categories;
using SimpraFinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Application.Features.Commands.Categories.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, UpdateCategoryCommandResponse>
    {
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly ICategoryWriteRepository _categoryWriteRepository;

        public UpdateCategoryCommandHandler(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }

        public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            Category category = await _categoryReadRepository.GetByIdAsync(request.Id);
            category.UpdatedBy = request.UpdatedBy;
            category.CreatedBy = request.CreatedBy;
            category.UpdatedAt = DateTime.UtcNow;
            category.CreatedAt = DateTime.UtcNow;
            category.Name = request.Name;
            category.Order = request.Order;
            await _categoryWriteRepository.SaveAsync();
            return new();
        }

    }
}
