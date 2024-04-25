using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Features.Queries;
using OnionArchitectureApp.Application.Interfaces.Repository;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public String Name { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }



        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            IProductRepository productRepository;
          
            public CreateProductCommandHandler(IProductRepository _productRepository)
            {
                productRepository = _productRepository;
              
            }

            public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {

                Product product = new Product();
                product.Name = request.Name;
                product.Value = request.Value;
                product.Quantity = request.Quantity;
                //var product = _mapper.Map<Product>(request);
                await productRepository.AddAsync(product);
                return product.Id;
            }
        }
    }
}
