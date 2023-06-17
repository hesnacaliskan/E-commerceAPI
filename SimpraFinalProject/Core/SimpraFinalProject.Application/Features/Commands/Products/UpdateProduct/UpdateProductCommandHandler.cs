using MediatR;
using SimpraFinalProject.Application.Repositories.Products;
using SimpraFinalProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Application.Features.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IProductWriteRepository _productWriteRepository;

        public UpdateProductCommandHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product= await _productReadRepository.GetByIdAsync(request.Id);
            product.UpdatedBy = request.UpdatedBy;
            product.CreatedBy = request.CreatedBy;
            product.UpdatedAt = DateTime.UtcNow;
            product.CreatedAt = DateTime.UtcNow;
            product.Name = request.Name;
            product.CategoryId = request.CategoryId;
            product.Url = request.Url;
            product.Tag = request.Tag;            
            await _productWriteRepository.SaveAsync();
            return new();
        }

    }
}
