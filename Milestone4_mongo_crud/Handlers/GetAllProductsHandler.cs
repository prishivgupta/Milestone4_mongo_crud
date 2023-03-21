using crud_mongo.Models;
using MediatR;
using Milestone4_mongo_crud.Interfaces;
using Milestone4_mongo_crud.Queries;

namespace Milestone4_mongo_crud.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<ProductModel>>
    {
        private readonly IProduct product;

        public GetAllProductsHandler(IProduct product)
        {
            this.product = product;
        }

        public async Task<List<ProductModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product.GetAllProducts());
        }
    }
}
