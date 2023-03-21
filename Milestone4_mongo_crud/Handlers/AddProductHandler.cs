using crud_mongo.Models;
using MediatR;
using Milestone4_mongo_crud.Commands;
using Milestone4_mongo_crud.Interfaces;

namespace Milestone4_mongo_crud.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, ProductModel>
    {
        private readonly IProduct product;

        public AddProductHandler(IProduct product)
        {
            this.product = product;
        }

        public async Task<ProductModel> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(product.AddProduct(request.product));
        }
    }
}
