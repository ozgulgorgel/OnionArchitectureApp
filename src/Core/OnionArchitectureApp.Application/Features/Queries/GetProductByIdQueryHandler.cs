using MediatR;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetAllProductResponse>
    {
        IProductRepository _productRepository;
        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;  
        }



        public async Task<GetAllProductResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var product = await _productRepository.GetById(request.Id);
            GetAllProductResponse response = new GetAllProductResponse();
            response.Id = product.Id;
            response.Name = product.Name;


            return response;

        }
    }
}
