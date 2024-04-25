using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries
{
    public class GetProductByIdQuery:IRequest<GetAllProductResponse>
    {
        public int Id { get; set; }
    }
}
