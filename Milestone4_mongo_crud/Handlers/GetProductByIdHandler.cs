using crud_mongo.Models;
using MediatR;
using Milestone4_mongo_crud.Interfaces;
using Milestone4_mongo_crud.Queries;

namespace Milestone4_mongo_crud.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductModel>
    {
        private readonly IProduct product;

        public GetProductByIdHandler(IProduct product)
        {
            this.product = product;
        }

        public async Task<ProductModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product.GetProductById(request.id));
        }
    }
}
