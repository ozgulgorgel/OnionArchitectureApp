using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries
{
    //bu query cağrıldığında bu handler devreye girecek
    public class GetAllProductQuery : IRequest<List<GetAllProductResponse>>
    {

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductResponse>>
        {
            private readonly IProductRepository productRepository;
         
            public GetAllProductQueryHandler(IProductRepository _productrepository)
            {
                productRepository = _productrepository;
               
            }

            public async Task<List<GetAllProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAll();
             
                var responseList = products.Select(entity => new GetAllProductResponse
                {
                    Id = entity.Id,
                    Name = entity.Name
                }).ToList();
                return responseList;
               

            }
        }
    }
}
